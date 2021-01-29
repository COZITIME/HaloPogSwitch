using System;
using System.Text;

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


            Meme().WriteByteArray(getter.GetFullAdress(), new byte[] { value } );
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

            byte[] bytes = new byte[textLength *2];

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
    public class ComplexBoolAdressSetter : BoolAdressSetter
    {
        readonly byte falseV = 18, trueV = 38;

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
            Meme().WriteByteArray(getter.GetFullAdress(), new byte[] { value ? trueV : falseV } );
        }
    }
    public abstract class AdressUIManager
    {
       //public AdressUIManager (AdressSetter setter)
       // {

       // }
    }
}
