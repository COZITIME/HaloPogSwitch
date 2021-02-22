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
        public IntPtr GetFullAdress(int address)
        {
            var process = ProcessEditorHandler.instance.WaitGetProcess();

            while (ProcessEditorHandler.instance.GetModuleFromEnun(moduleType) == null)
            {
                return new IntPtr();
                // Thread.Sleep(500);
            }



            IntPtr mod = ProcessEditorHandler.instance.GetModuleFromEnun(moduleType).BaseAddress;



            return mod + address;
        }
        public IntPtr GetFullAdress()
        {

          //  Thread.Sleep(50);
            


            var process = ProcessEditorHandler.instance.WaitGetProcess();

            while(ProcessEditorHandler.instance.GetModuleFromEnun(moduleType) == null)
            {
                return new IntPtr();
                // Thread.Sleep(500);
            }

     
            
            IntPtr mod = ProcessEditorHandler.instance.GetModuleFromEnun(moduleType).BaseAddress;
           


            return mod + adress;
        }


       
    }






}
