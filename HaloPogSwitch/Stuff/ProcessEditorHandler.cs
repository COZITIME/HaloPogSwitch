using System;
using System.Diagnostics;
using System.Threading;

namespace HaloPogSwitch.Stuff
{
    public class ProcessEditorHandler
    {
        public static ProcessEditorHandler instance;

        Process myProcess;
        HaloModules modules;

        public VAMemory memory;

        public void UpdateProcess()
        {
            
  
            while (myProcess == null)
            {
                

                var procs = Process.GetProcessesByName(processName);

                if (procs.Length > 0)
                {
                    myProcess = procs[0];
                    continue;
                }
                else
                {
                    myProcess = null;
                    Thread.Sleep(50);
                }

            }

           

                UpdateModules(myProcess);
            memory = new VAMemory(myProcess.ProcessName);

        }

        internal VAMemory GetMemory()
        {
            while (myProcess == null || memory == null) 
            {
               
                UpdateProcess();
                Thread.Sleep(5);
            }
           

            return memory;
        }

        public void Awake()
        {
            instance = this;
        }

        public void UpdateModules(Process process)
        {
            if (process == null) return;
           

            ProcessModuleCollection mods = process.Modules;
            foreach (ProcessModule m in mods)
            {
                switch (m.ModuleName)
                {
                    case processName:
                        modules.baseMod = m;
                        break;
                    case modNameReach:
                        modules.reachMod = m;
                        break;
                    case modNameHalo4:
                        modules.halo4Mod = m;
                        break;
                    case modNameHalo2A:
                       
                        modules.halo2AMod = m;
                        Console.WriteLine(modules.halo2AMod.BaseAddress);
                        break;
                }
            }

        }

        public Process WaitGetProcess()
        {
            if (myProcess == null) UpdateProcess();
            return myProcess;
        }

        public ProcessModule GetModuleFromEnun(ModuleType module)
        {

            switch (module)
            {
                case ModuleType.baseModule:
                    return modules.baseMod;
                case ModuleType.reach:
                    return modules.reachMod;
                case ModuleType.halo4:
                    return modules.halo4Mod;
                case ModuleType.halo2A:
                    Console.WriteLine("Getting H2a Mod ");
                    Console.WriteLine(modules.halo2AMod);
                    return modules.halo2AMod;
            }

            return null;
        }


        private const string processName = "MCC-Win64-Shipping";
        private const string modNameReach = "haloreach.dll";
        private const string modNameHalo4 = "halo4.dll";
        private const string modNameHalo2A = "groundhog.dll";

        public ProcessEditorHandler()
        {
            instance = this;
        }

        public struct HaloModules
        {
            public ProcessModule baseMod;
            public ProcessModule reachMod;
            public ProcessModule halo4Mod;
            public ProcessModule halo2AMod;
        }
    }








}
