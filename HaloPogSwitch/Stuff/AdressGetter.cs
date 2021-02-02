using System;
using System.Threading;

namespace HaloPogSwitch.Stuff
{
    public class AdressGetter
    {
        public int adress;
        public ModuleType moduleType;

        public AdressGetter(ModuleType moduleType, int adress)
        {

            this.moduleType = moduleType;
            this.adress = adress;
            
        }

        public IntPtr GetFullAdress()
        {

            Thread.Sleep(50);

            

            var process = ProcessEditorHandler.instance.GetModuleFromEnun(moduleType);

            while (process.BaseAddress == null)
            {
                Thread.Sleep(100);
            }


     //       Console.WriteLine("MODTYPE "+ ProcessEditorHandler.instance.GetModuleFromEnun(moduleType));
            
            IntPtr mod = process.BaseAddress;
//Console.Write(mod);


            return mod + adress;
        }


       
    }






}
