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
            


            var process = ProcessEditorHandler.instance.WaitGetProcess();

            while(ProcessEditorHandler.instance.GetModuleFromEnun(moduleType) == null)
            {
                Thread.Sleep(500);
            }

     Console.WriteLine("MODTYPE "+ ProcessEditorHandler.instance.GetModuleFromEnun(moduleType));
            
            IntPtr mod = ProcessEditorHandler.instance.GetModuleFromEnun(moduleType).BaseAddress;
            //Console.Write(mod);


            return mod + adress;
        }


       
    }






}
