using Siticone.UI.WinForms;
using System;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace HaloPogSwitch.Stuff
{
    public class ProcessEditorHandler
    {
        public static ProcessEditorHandler instance;

        Process myProcess;
        HaloModules modules;

        public VAMemory memory;


        private const string processName = "MCC-Win64-Shipping";

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
            haloMods.UpdateButtons();

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

                foreach (KeyValuePair<ModuleType, ModuleData> item in haloMods.moduals)
                {
                    if (item.Value.moduleName == m.ModuleName)
                    {
                        item.Value.moduleName = m.ModuleName;
                        item.Value.modual = m;
                    }
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
            return haloMods.GetModuleByType(module).modual;
        }


        //private const string modNameReach = "haloreach.dll";
        //private const string modNameHalo4 = "halo4.dll";
        //private const string modNameHalo2A = "groundhog.dll";

        public ProcessEditorHandler()
        {
            instance = this;
        }

        //public struct HaloModules
        //{
        //    public ProcessModule baseMod;
        //    public ProcessModule reachMod;
        //    public ProcessModule halo4Mod;
        //    public ProcessModule halo2AMod;
        //}


        public HaloModules haloMods = new HaloModules();


        public class HaloModules
        {
            public Dictionary<ModuleType, ModuleData> moduals = new Dictionary<ModuleType, ModuleData>();

            public HaloModules()
            {
                AddEntries();
            }

            public void AddEntries()
            {
                moduals.Add(ModuleType.baseModule, new ModuleData("MCC-Win64-Shipping"));
                moduals.Add(ModuleType.reach, new ModuleData("haloreach.dll"));
                moduals.Add(ModuleType.halo2A, new ModuleData("modNameHalo2A"));
                moduals.Add(ModuleType.halo4, new ModuleData("halo4.dll"));
            }

            public ModuleData GetModuleByType(ModuleType type)
            {
                return moduals[type];
            }

            public void UpdateButtons()

            {
                foreach (var item in moduals)
                {
                    item.Value.UpdateButton();
                }
            }
        }


        public class ModuleData
        {

            public ProcessModule modual;
            public string moduleName;

            public SiticoneButton modButton;

            public void UpdateButton()
            {
                if (modButton != null)
                modButton.Enabled = modual != null;
            }

            public ModuleData(string modualName)
            {

                this.moduleName = modualName;

            }
        }


        public void PairModule(SiticoneButton button, ModuleType mod)
        {
            haloMods.moduals[mod].modButton = button;
        }

       
    }








}
