using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UI32;
using System.Windows.Forms;
using HaloPogSwitch.Stuff;
using System.Reflection;
using static UI32.tableLayoutPanel1;
using System.Drawing;
using System.Globalization;

namespace HaloPogSwitch
{

    class CSVPuller
    {

        public static UI32.TrainerEnumButton GetTrainerEnumFromFile(string file)
        {

            string titleThing = "";

            List<ValueStringPair> diffrentValues = new List<ValueStringPair>();

            using (var reader = new StreamReader(file))
            {
                int l = 0;
                while (!reader.EndOfStream)
                {
                    l++;

                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (l == 1)
                    {
                        titleThing = values[1];
                    }

                    if (l > 5)
                    {
                        byte value = byte.Parse(values[1], NumberStyles.HexNumber);
                        string name = values[0];
                        diffrentValues.Add(new ValueStringPair(value, name));
                    }

                }



                return new TrainerEnumButton(titleThing, diffrentValues.ToArray());
            }

        }


        public static UI32.tableLayoutPanel1 GetTrainerColourButtonsFromFile(string file)
        {

            string titleThing = "";

            List<ColourData<byte>> colours = new List<ColourData<byte>>();

            using (var reader = new StreamReader(file))
            {
                int l = 0;
                while (!reader.EndOfStream)
                {
                    l++;

                    string line = reader.ReadLine();
                    string[] values = line.Split(',');


                    if (l == 1)
                    {
                        titleThing = values[1];
                    }


                    if (l > 5)
                    {


                        string[] colourNameSplit = values[0].Split('-');

                        byte val = byte.Parse(values[1], System.Globalization.NumberStyles.HexNumber);
                        Color col = ColorTranslator.FromHtml(colourNameSplit[0]);
                        string colName = colourNameSplit[1];


                        ColourData<byte> colourD = new ColourData<byte>(col, colName, val);

                        colours.Add(colourD);

                    }



                }

                return new tableLayoutPanel1(titleThing, colours.ToArray());
            }

        }

        internal static TrainerUpdater<byte> GetTrainerUpdater<T>(string fileName, Control.ControlCollection Controls, long Taddress = 0)
        {
            string file = GetFile(fileName);


            bool isTree = false;
            bool isColour = false;

            long address = 0;
            ModuleType moduleType = ModuleType.baseModule;



            using (var reader = new StreamReader(file))
            {

                int l = 0;
                while (!reader.EndOfStream)
                {
                    l++;

                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (l == 3)
                    {
                        if (Taddress == 0)
                        {
                            address = Convert.ToInt32(values[1], 16);
                        }
                        else
                        {
                            address = Taddress;
                        }
                    }

                    if (l == 2)
                    {
                        moduleType = ModFromString(values[1]);
                    }

                    if (l > 5 && values[0].Contains(':')) isTree = true;
                    if (l > 5 && values[0].Contains('#')) isColour = true;

                }

            }

            ITrainerUI<byte> ui;

            if (isColour)
            {
                ui = GetTrainerColourButtonsFromFile(file);
            }
            else if (isTree)
            {
                ui = GetTrainerButtonArrayFromFile(file);
            }
            else
            {
                ui = GetTrainerEnumFromFile(file);
            }




            var t = new TrainerUpdater<byte>(new ByteAdressSetter(new AdressGetter(moduleType, (int)address)), ui, Controls);

            return t;


        }


        private static TrainerEnumButtonArray GetTrainerButtonArrayFromFile(string file)
        {
            string titleThing = "";

            List<Node> nodes = new List<Node>();


            using (var reader = new StreamReader(file))
            {
                int l = 0;
                while (!reader.EndOfStream)
                {
                    l++;

                    string line = reader.ReadLine();
                    string[] values = line.Split(',');


                    if (l == 1)
                    {
                        titleThing = values[1];
                    }


                    if (l > 5)
                    {

                        byte value = byte.Parse(values[1], System.Globalization.NumberStyles.HexNumber);
                        string name = values[0];

          

                        string[] nameSplit = name.Split(':');



                        for (int i = 0; i < nameSplit.Length; i++)
                        {
                            if (i == 0)
                            {
                                var fn = nodes.FirstOrDefault(n => n.title == nameSplit[0]);
                                if (fn == null)
                                {

                                    nodes.Add(fn = new Node(nameSplit[0], 0));
                                }

                                if (nameSplit.Length == 1)
                                {
                                    fn.value = value;
                                }

                            }
                            else
                            {
                                Node pnode = nodes.FirstOrDefault(n => n.title == nameSplit[i - 1]);
                                if (pnode == null)
                                {
                                    pnode = new Node(nameSplit[i - 1], 0);

                                }
                                else if (pnode.nodes.Count == 0)
                                {
                                    pnode.nodes.Add(new Node("Base", pnode.value));
                                }


                                if (pnode != null) pnode.nodes.Add(new Node(nameSplit[i], value));
                            }


                        }



                    }

                }



            }


            return new TrainerEnumButtonArray(titleThing, nodes);
        }

        //private static TrainerTreeList GetTrainerTreeFromFile(string file)
        //{
        //    string titleThing = "";


        //    List<ValueTreeNode<byte>> nodes = new List<ValueTreeNode<byte>>();


        //    using (var reader = new StreamReader(file))
        //    {
        //        int l = 0;
        //        while (!reader.EndOfStream)
        //        {
        //            l++;

        //            string line = reader.ReadLine();
        //            string[] values = line.Split(',');


        //            if (l == 1)
        //            {
        //                titleThing = values[1];
        //            }


        //            if (l > 5)
        //            {

        //                byte value = byte.Parse(values[1], System.Globalization.NumberStyles.HexNumber);
        //                string name = values[0];

        //                // Animal:Dog:Star
        //                // Animal:Cat:Yeet
        //                // Animal:Dog:Base

        //                string[] nameSplit = name.Split(':');



        //                for (int i = 0; i < nameSplit.Length; i++)
        //                {
        //                    if (i == 0)
        //                    {
        //                        var fn = nodes.FirstOrDefault(n => n.Text == nameSplit[0]);
        //                        if (fn == null)
        //                        {
        //                            nodes.Add(fn = new ValueTreeNode<byte>(nameSplit[0], 0));
        //                        }
        //                        if (nameSplit.Length == 1)
        //                        {
        //                            fn.value = value;
        //                        }

        //                    }
        //                    else
        //                    {
        //                        ValueTreeNode<byte> pnode = nodes.FirstOrDefault(n => n.Text == nameSplit[i - 1]);
        //                        if (pnode == null)
        //                        {
        //                            pnode = new ValueTreeNode<byte>(nameSplit[i - 1], 0);
        //                        }
        //                        else if (pnode.Nodes.Count == 0)
        //                        {
        //                            pnode.Nodes.Add(new ValueTreeNode<byte>("base", pnode.value));
        //                        }

        //                        pnode.Nodes.Add(new ValueTreeNode<byte>(nameSplit[i], value));
        //                    }


        //                }

        //            }



        //        }

        //        return new TrainerTreeList(titleThing, nodes.ToArray());
        //    }
        //}

        public static ModuleType ModFromString(string stringValue)
        {
            return ProcessEditorHandler.instance.haloMods.GetModTypeViaString(stringValue);



        }

        public static string GetFile(string fileName)
        {

            return Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"Data\", fileName);
        }

        internal static void GetLoadoutTrainerUpdater(Control.ControlCollection controls, int loadOutOffset)
        {
            LoadOut.LoudoutUIData UIData = new LoadOut.LoudoutUIData(GetWeaponData(), GetByteNames(@"H4L_Ability.csv"), GetByteNames(@"H4L_Mods.csv"), GetByteNames(@"H4L_Grenade.csv"));
            

            LoadoutAdressSetter trainerUpdater = new LoadoutAdressSetter(new AdressGetter(ModuleType.halo4, 0));



           var t = new TrainerUpdater<LoadoutData>(trainerUpdater, new LoadOut(UIData), controls);
           
        }

        public static int GetAddress (string fileName)
        {
            string file = GetFile(fileName);
            file.Split(new string[] { "Adress," }, StringSplitOptions.None);
            file.Split(new string[] { "," }, StringSplitOptions.None);

            return Convert.ToInt32(file, 16);
        }

        public static SortedList<byte, string> GetByteNames(string fileName)
        {
            string file = GetFile(fileName);
            SortedList<byte, string> dict = new SortedList<byte, string>();



            using (var reader = new StreamReader(file))
            {
                int Line = 0;


                while (!reader.EndOfStream)
                {
                    Line++;
                    string[] values = reader.ReadLine().Split(',');

                    if (Line > 5)
                    {

                      
                        byte b = Convert.ToByte(values[1], 16);
                        string name = values[0];

                        dict.Add(b, name);


                    }
                }

            }

            return dict;
        }

        public static LoadOut.WeaponUiData GetWeaponData()
        {
            LoadOut.WeaponUiData weaponData = new LoadOut.WeaponUiData();
            weaponData.weapons = new SortedList<byte, LoadOut.WeaponUiData.WeaponSkinUiData>();
            string file = GetFile(@"H4L_Weapons.csv");

            using (var reader = new StreamReader(file))
            {
                int Line = 0;


                while (!reader.EndOfStream)
                {
                    Line++;
                    string[] values = reader.ReadLine().Split(',');
                    if (Line > 5)
                    {
                       

                        LoadOut.WeaponUiData.WeaponSkinUiData weaponSkinData = new LoadOut.WeaponUiData.WeaponSkinUiData();
                        byte b = Convert.ToByte(values[1], 16);


                        weaponSkinData.weaponName = values[0];
                        weaponSkinData.skins = new SortedList<byte, string>();

                        weaponSkinData.skins.Add(0, "base");

                        byte sb = 1;
                        for (int i = 2; i < values.Length; i++)
                        {
                            if (values[i] != "") weaponSkinData.skins.Add(sb, values[i]);
                            sb++;

                            
                        }

                    
                        weaponData.weapons.Add(b, weaponSkinData);

                    }
                }

            }

            return weaponData;
        }


    }

    


}
