using System;
using System.Collections;
using System.Text;
using UI32;

namespace HaloPogSwitch.Stuff
{
    public abstract class AdressSetter<T>
    {
        public AdressGetter getter;
        public AdressSetter(AdressGetter getter)
        {
            this.getter = getter;
        }
        public abstract void WriteMemory(T value);
        public abstract T ReadMemory();
        public VAMemory Meme()
        {
            return ProcessEditorHandler.instance.GetMemory();
        }
    }
    public class Int16AdressSetter : AdressSetter<short>
    {
        public Int16AdressSetter(AdressGetter getter) : base(getter)
        {

        }
        public override short ReadMemory()
        {
            return Meme().ReadInt16(getter.GetFullAdress());
        }
        public override void WriteMemory(short value)
        {

            Meme().WriteInt16(getter.GetFullAdress(), value);
        }
    }

    public class LoadoutAdressSetter : AdressSetter<LoadoutData>
    {




        public LoadoutAdressSetter(AdressGetter getter) : base(getter)
        {
            loadoutIndex = 0;
            ReadMemory();

            LoadOut.ichange += IndexChanged;
        }

        public int loadoutIndex;



        public IntPtr GetOffsetAddress(int address, int offsetunit = 28)
        {
            int offset = loadoutIndex * offsetunit;
            address += offset;
            return getter.GetFullAdress(address);
        }



        // TODO: fix these addresses, why are they like this??
        LoadoutBaseAddresses baseAddresses = new LoadoutBaseAddresses(0x2D654D0 + 0x6310, 
                                                                      0x2D65448 + 0x6310, 
                                                                      0x2D65444 + 0x6310, 
                                                                      0x2D65430 + 0x6310, 
                                                                      0x2D65434 + 0x6310, 
                                                                      0x2D65438 + 0x6310, 
                                                                      0x2D6543C + 0x6310, 
                                                                      0x2D65440 + 0x6310, 
                                                                      0x2D65441 + 0x6310);


        public void IndexChanged(int val)
        {
            loadoutIndex = val;
            LoadOut.dataUpdate?.Invoke(ReadMemory());
        }

        struct LoadoutBaseAddresses
        {
            public int name;
            public int grenade, ablity, moda, modb;
            public int weaponPrimary, weaponSecondary;
            public int weaponSkinPrimary, weaponSkinSecondary;

            public LoadoutBaseAddresses(int name, int grenade, int ablity, int moda, int modb, int weaponPrimary, int weaponSecondary, int weaponSkinPrimary, int weaponSkinSecondary)
            {
                this.name = name;
                this.grenade = grenade;
                this.ablity = ablity;
                this.moda = moda;
                this.modb = modb;
                this.weaponPrimary = weaponPrimary;
                this.weaponSecondary = weaponSecondary;
                this.weaponSkinPrimary = weaponSkinPrimary;
                this.weaponSkinSecondary = weaponSkinSecondary;
            }
        }

        public override LoadoutData ReadMemory()
        {
            string n = Meme().ReadStringUnicode((IntPtr)GetOffsetAddress(baseAddresses.name, 26), 24);

            byte a = Meme().ReadByte((IntPtr)GetOffsetAddress(baseAddresses.ablity));
            byte g = Meme().ReadByte((IntPtr)GetOffsetAddress(baseAddresses.grenade));
            byte m0 = Meme().ReadByte((IntPtr)GetOffsetAddress(baseAddresses.moda));
            byte m1 = Meme().ReadByte((IntPtr)GetOffsetAddress(baseAddresses.modb));

            byte wp = Meme().ReadByte((IntPtr)GetOffsetAddress(baseAddresses.weaponPrimary));
            byte wps = Meme().ReadByte((IntPtr)GetOffsetAddress(baseAddresses.weaponSkinPrimary));
            byte ws = Meme().ReadByte((IntPtr)GetOffsetAddress(baseAddresses.weaponSecondary));
            byte wss = Meme().ReadByte((IntPtr)GetOffsetAddress(baseAddresses.weaponSkinSecondary));

            return new LoadoutData(n, wp, wps, ws, wss, a, g, m0, m1);
        }

        public override void WriteMemory(LoadoutData value)
        {

            byte[] nameBytes = Encoding.Unicode.GetBytes(value.name);
            Array.Resize<byte>(ref nameBytes, 24);
            Meme().WriteByteArray(GetOffsetAddress(baseAddresses.name, 26), nameBytes);


            Meme().WriteByte((IntPtr)GetOffsetAddress(baseAddresses.weaponPrimary), value.primary.weapon);
            Meme().WriteByte((IntPtr)GetOffsetAddress(baseAddresses.weaponSkinPrimary), value.primary.skin);
            Meme().WriteByte((IntPtr)GetOffsetAddress(baseAddresses.weaponSecondary), value.secondary.weapon);
            Meme().WriteByte((IntPtr)GetOffsetAddress(baseAddresses.weaponSkinSecondary), value.secondary.skin);

            Meme().WriteByte((IntPtr)GetOffsetAddress(baseAddresses.ablity), value.ability);
            Meme().WriteByte((IntPtr)GetOffsetAddress(baseAddresses.grenade), value.grenade);
            Meme().WriteByte((IntPtr)GetOffsetAddress(baseAddresses.moda), value.mod0);
            Meme().WriteByte((IntPtr)GetOffsetAddress(baseAddresses.modb), value.mod1);
        }
    }

    public class ByteAdressSetter : AdressSetter<byte>
    {
        public ByteAdressSetter(AdressGetter getter) : base(getter)
        {
            ReadMemory();
        }
        public override byte ReadMemory()
        {
            var val = Meme().ReadByte(getter.GetFullAdress());
            var adress = Convert.ToString(getter.GetFullAdress().ToInt64(), 16);


            return val;
        }
        public override void WriteMemory(byte value)
        {

            ///   var val = Meme().ReadByte(getter.GetFullAdress());
            /// var adress = Convert.ToString(getter.GetFullAdress().ToInt64(), 16);


            Meme().WriteByteArray(getter.GetFullAdress(), new byte[] { value });
        }

        public static string ByteArrayToString(params byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }


    public class StringAdressSetter : AdressSetter<string>
    {
        private int textLength;
        public StringAdressSetter(AdressGetter getter, int textLength) : base(getter)
        {
            this.textLength = textLength;
        }

        public override string ReadMemory()
        {

            string value = Meme().ReadStringUnicode(getter.GetFullAdress(), (uint)(textLength * 2));

            return value;
        }

        public override void WriteMemory(string value)
        {
            //if (textLength == 4)
            //{
            //    Meme().WriteLong(getter.GetFullAdress(), System.Convert.ToInt64(value));
            //} else

            byte[] bytes = new byte[textLength * 2];

            Meme().WriteByteArray(getter.GetFullAdress(), bytes);
            Meme().WriteStringUnicode(getter.GetFullAdress(), value);

        }
    }

    public class BoolAdressSetter : AdressSetter<bool>
    {
        public BoolAdressSetter(AdressGetter getter) : base(getter)
        {

        }
        public override bool ReadMemory()
        {

            return Meme().ReadBoolean(getter.GetFullAdress());
        }
        public override void WriteMemory(bool value)
        {
            Meme().WriteBoolean(getter.GetFullAdress(), value);
        }
    }

    //public class LongComplexBoolAdressSetter : ComplexBoolAdressSetter
    //{
    //    int length;
    //    public LongComplexBoolAdressSetter(AdressGetter getter, byte falseValue, byte trueValue, int length) : base(getter, falseValue, trueValue)
    //    {
    //        this.length = length;
    //    }

    //    public override void WriteMemory(bool value)
    //    {
    //        byte[] bytes = new byte[length];
    //        for (int i = 0; i < bytes.Length; i++)
    //        {
    //            bytes[i] = value ? trueV : falseV;

    //        }

    //        Meme().WriteByteArray(getter.GetFullAdress(),bytes);
    //    }
    //}


    public class BytesComplexBoolAdressSetter : BoolAdressSetter
    {
        readonly public byte[] falseV, trueV;
        bool ready = true;
        public BytesComplexBoolAdressSetter(AdressGetter getter, byte[] falseValue, byte[] trueValue) : base(getter)
        {
            this.falseV = falseValue;
            this.trueV = trueValue;

            //timer = new System.Timers.Timer(1000);
            //timer.Elapsed += (a, b) => ready = true;
        }
        public override bool ReadMemory()
        {
            var bVal = Meme().ReadByteArray(getter.GetFullAdress(), (uint)falseV.Length);

            if (bVal == trueV)
            {
                return true;
            }
            else if (bVal == falseV)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        public override void WriteMemory(bool value)
        {
            // ReadOnReady(value);
            Console.WriteLine("3rd Person: " + value);
            Meme().WriteByteArray(getter.GetFullAdress(), value ? trueV : falseV);
        }
      

        //async Task(bool value)
        //{
        //    yield return ready;

           

        //    ready = false;
        //    timer.Start();
        //}

      //  System.Timers.Timer timer;
    }




    public class ComplexBoolAdressSetter : BoolAdressSetter
    {
        readonly protected byte falseV = 18, trueV = 38;

        public ComplexBoolAdressSetter(AdressGetter getter, byte falseValue, byte trueValue) : base(getter)
        {
            this.falseV = falseValue;
            this.trueV = trueValue;
        }
        public override bool ReadMemory()
        {
            var bVal = Meme().ReadByte(getter.GetFullAdress());

            if (bVal == trueV)
            {
                return true;
            }
            else if (bVal == falseV)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        public override void WriteMemory(bool value)
        {
            Meme().WriteByteArray(getter.GetFullAdress(), new byte[] { value ? trueV : falseV });
        }
    }
    public abstract class AdressUIManager
    {
        //public AdressUIManager (AdressSetter setter)
        // {

        // }
    }
}
