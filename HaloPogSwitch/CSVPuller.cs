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

        internal static TrainerUpdater<byte> GetTrainerUpdater<T>(string fileName, Control.ControlCollection Controls, long Taddress  = 0)
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


           

            var t = new TrainerUpdater<byte>(new ByteAdressSetter(new AdressGetter(moduleType, (int) address)), ui, Controls);

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

                        // Animal:Dog:Star
                        // Animal:Cat:Yeet
                        // Animal:Dog:Base

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
    }


    static class ExtensionMethods
    {
        public static Color ToColor(this uint argb)
        {
            return Color.FromArgb((byte)((argb & -16777216) >> 0x18),
                                  (byte)((argb & 0xff0000) >> 0x10),
                                  (byte)((argb & 0xff00) >> 8),
                                  (byte)(argb & 0xff));
        }
    }
}
