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

namespace HaloPogSwitch
{


    class CSVPuller
    {
        bool poop = false;
        public static UI32.TrainerEnum GetTrainerEnumFromFile(string file)
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

                        byte value = byte.Parse(values[1], System.Globalization.NumberStyles.HexNumber);
                        string name = values[0];
                        diffrentValues.Add(new ValueStringPair(value, name));
                    }

                  //  Console.WriteLine(values[1] + ", " + values[0]);

                }

                return new TrainerEnum(titleThing, diffrentValues.ToArray());
            }

        }

        internal static TrainerUpdater<byte> GetTrainerUpdater<T>(string fileName, Control.ControlCollection Controls)
        {
            string file = GetFile(fileName);
            // Console.WriteLine(file);

            bool isTree = false;

            int address = 0;
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
                       // Console.WriteLine("Adress: "+ values[1]);
                        address=  Convert.ToInt32(values[1], 16);
                    }

                    if (l == 2) 
                    {

                        moduleType = ModFromString(values[1]);

                    }

                    if (l > 5 && values[0].Contains(':')) isTree = true;
                

                }

            }

            TrainerUI<byte> ui; 
            
            

            if (isTree)
            {
                ui = GetTrainerTreeFromFile(file);
            } else
            {
                ui = GetTrainerEnumFromFile(file);
            }
          

           

            var t = new  TrainerUpdater<byte>(new ByteAdressSetter(new AdressGetter(ModuleType.reach, address)), ui, Controls);

            return t;

          
        }

        private static TrainerTreeList GetTrainerTreeFromFile(string file)
        {
            string titleThing = "";


            List<ValueTreeNode<byte>> nodes = new List<ValueTreeNode<byte>>(); 
            
          
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
                               var fn = nodes.FirstOrDefault(n => n.Text == nameSplit[0]);
                                if (fn == null)
                                {
                                    nodes.Add(fn = new ValueTreeNode<byte>(nameSplit[0], 0));
                                }
                                if (nameSplit.Length == 1)
                                {
                                    fn.value = value;
                                }
                                  
                            } else
                            {
                                ValueTreeNode<byte> pnode = nodes.FirstOrDefault(n => n.Text == nameSplit[i - 1]);
                                if (pnode == null)
                                {
                                    pnode = new ValueTreeNode<byte>(nameSplit[i - 1], 0);
                                }
                                else if (pnode.Nodes.Count == 0)
                                {
                                    pnode.Nodes.Add(new ValueTreeNode<byte>("base", pnode.value));
                                }

                                pnode.Nodes.Add(new ValueTreeNode<byte>(nameSplit[i], value));
                            }

                            
                        }

                    }

                 

                }

                return new TrainerTreeList(titleThing, nodes.ToArray());
            }
        }

        public static ModuleType ModFromString (string stringValue)
        {
            switch (stringValue)
            {
                case "haloreach.dll":
                    return ModuleType.reach;
                case "halo4.dll":
                    return ModuleType.halo4;
                default:
                    return ModuleType.baseModule;
            }
        }

        public static string GetFile(string fileName)
        {

            return Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"Data\", fileName);
        }
    }

    

}
