using HaloPogSwitch.Stuff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI32;


namespace HaloPogSwitch
{
    public partial class MyForm : Form
    {

        public static System.Windows.Forms.Timer shuffleTimer = new System.Windows.Forms.Timer();

        public ProcessEditorHandler processHandler = new ProcessEditorHandler();

        public int prevOpenCount = 0;
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        public MyForm()
        {
            InitializeComponent();

            backgroundWorker1.RunWorkerAsync();
            Application.Idle += HandleApplicationIdle;

            shuffleTimer.Interval = 1000;
            shuffleTimer.Start();
        }
        int pp = 0;
        void HandleApplicationIdle(object sender, EventArgs e)
        {
            pp++;

            if (pp > 1000) 
            {
               
                processHandler.UpdateProcess();

               int openCount = processHandler.haloMods.GetOpenCount();
                if (openCount != prevOpenCount)
                {
                    prevOpenCount = openCount;
                    uIUpdate?.Invoke();
                }
               
                pp = 0;
            }
        
        }

        

        string[] strings = new string[10];
        
        public void DoStuff()  
        {


            for (int i = 0; i < strings.Length; i++)
            {
                
                string value = strings[i];
            }

          
            
        }
        
      

        private void FuckingCunt_Load(object sender, EventArgs e)
        {
            byte nop = 0x90;

            DoStuff();

            siticoneShadowForm1.SetShadowForm(this);
            //var helmateEnumUi = CSVPuller.GetTrainerEnumFromFile(@"C:\Users\Magic\source\repos\HaloPogSwitch\Data\Reach_Helm.csv");
            processHandler.GetMemory();

            // controls for where we instatiate the uis


            // Adress Value setters Linked to UI so they update automatically
            new TrainerUpdater<string>(new StringAdressSetter(new AdressGetter(ModuleType.reach, 0x27E7194 + 0x3F20), 4), new TrainerText("Service Tag", "4 Letter Tag:", 4, true, CharacterCasing.Upper, true), uC_HaloReach1.GetReachFlow(HaloReachMenuType.serviceid).Controls);
            new TrainerUpdater<bool>(new BoolAdressSetter(new AdressGetter(ModuleType.reach, 0x27E7174 + 0x3F20)), new TrainerBool("Species", "Elite Biped"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.species).Controls);
            new TrainerUpdater<bool>(new ComplexBoolAdressSetter(new AdressGetter(ModuleType.reach, 0x27E6FD8 + 0x3F20), 0x18, 0x38), new TrainerBool("Spartan Gender", "Is Female"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.gender).Controls);

            new TrainerUpdater<byte>(new ByteAdressSetter(new AdressGetter(ModuleType.reach, 0x27E7181 + 0x3F20)), CSVPuller.GetTrainerEnumFromFile(@"data\Reach_Chest.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.chest).Controls);
            //CSVPuller.GetTrainerUpdater<byte>((@"Reach_ColourPrimary.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.extra).Controls);
            //CSVPuller.GetTrainerUpdater<byte>((@"Reach_ColourSecondary.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.extra).Controls);

            // Also a bunch of Trainer Updaers - These use the CVS puller to get automatically created by the CVS files (seen on the google sheets)
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Helmate.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.helmateVisor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Visor.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.helmateVisor).Controls);
            // CSVPuller.GetTrainerUpdater<byte>((@"Reach_Chest.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.chest).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_LeftShoulder.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.shoulder).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_RightShoulder.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.shoulder).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Wrist.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.wrist).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Utility.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.utility).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Kneepad.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.knees).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_ArmorEffect.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.armoreffects).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_EliteArmor.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.elitearmor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_EliteEffects.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.eliteeffects).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_ColourPrimary.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.color).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_ColourSecondary.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.color).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_FireFightVoice.csv"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.firefightvoice).Controls);

           

            new TrainerUpdater<bool>(new BytesComplexBoolAdressSetter(new AdressGetter(ModuleType.reach, 0xA90FC), new byte[] {0x74, 0x0E}, new byte[] { nop, nop }), new TrainerBool("3rd Person Camera (Experimental)", "Use 3rd Person Camera"), uC_HaloReach1.GetReachFlow(HaloReachMenuType.camera).Controls);


            processHandler.PairModule(haloreach, ModuleType.reach);
            processHandler.PairModule(halo2a, ModuleType.halo2A);
       //     processHandler.PairModule(halo3, ModuleType.halo3);
            processHandler.PairModule(halo4, ModuleType.halo4);


            //  processHandler.PairModule(halo2a, ModuleType.halo2A);

            //C_HaloReach1.GetFlow(HaloReachMenuType.colour).Controls.Add(new TrainerEnumNestedButtonHolder());
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_ColourPrimary.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.color).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_ColourSecondary.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.color).Controls);

            //// Halo 2A

            new TrainerUpdater<string>(new StringAdressSetter(new AdressGetter(ModuleType.halo2A, 0x19BF62C + 0x2E30), 4), new TrainerText("Service Tag", "4 Letter Tag:", 4, true, CharacterCasing.Upper, true), uC_Halo2a1.GetHalo2AFlow(H2ATab.serviceid).Controls);
            new TrainerUpdater<bool>(new BoolAdressSetter(new AdressGetter(ModuleType.halo2A, 0x19BF60C + 0x2E30)), new TrainerBool("Species", "Elite Biped"), uC_Halo2a1.GetHalo2AFlow(H2ATab.species).Controls);
            new TrainerUpdater<bool>(new ComplexBoolAdressSetter(new AdressGetter(ModuleType.halo2A, 0x19BF448 + 0x2E30), 0x18, 0x38), new TrainerBool("Spartan Gender", "Is Female"), uC_Halo2a1.GetHalo2AFlow(H2ATab.gender).Controls);




            CSVPuller.GetTrainerUpdater<byte>((@"H2A_Helmates.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.helmateVisor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_Visors.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.helmateVisor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_Chest.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.chest).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_Arms.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.wrist).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_Legs.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.knees).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_LShoulder.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.shoulder).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_RShoulder.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.shoulder).Controls);


            ////thingys that i added
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_E_Helm.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.elitearmor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_E_Chest.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.elitearmor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_E_Arms.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.elitearmor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H2A_E_Legs.csv"), uC_Halo2a1.GetHalo2AFlow(H2ATab.elitearmor).Controls);


            new TrainerUpdater<bool>(new BytesComplexBoolAdressSetter(new AdressGetter(ModuleType.halo2A, 0xFDD4E), new byte[] { 0x74, 0x03 }, new byte[] { nop, nop }), new TrainerBool("3rd Person Camera (Experimental)", "Use 3rd Person Camera"), uC_Halo2a1.GetHalo2AFlow(H2ATab.camera).Controls);


            //// halo 4

            new TrainerUpdater<string>(new StringAdressSetter(new AdressGetter(ModuleType.halo4, 0x2D6AE14 + 0x1D64), 4), new TrainerText("Service Tag", "4 Letter Tag:", 4, true, CharacterCasing.Upper, true), uC_Halo41.GetHalo4Flow(Halo4MenuType.serviceid).Controls);
            new TrainerUpdater<bool>(new ComplexBoolAdressSetter(new AdressGetter(ModuleType.halo4, 0x2D6AC38 + 0x1D64), 0x18, 0x38), new TrainerBool("Spartan Gender", "Is Female"), uC_Halo41.GetHalo4Flow(Halo4MenuType.gender).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"H4_Helmets.csv"), uC_Halo41.GetHalo4Flow(Halo4MenuType.helmateVisor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H4_Visors.csv"), uC_Halo41.GetHalo4Flow(Halo4MenuType.helmateVisor).Controls);
      
            CSVPuller.GetTrainerUpdater<byte>((@"H4_L_Shoulder.csv"), uC_Halo41.GetHalo4Flow(Halo4MenuType.shoulder).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H4_R_Shoulder.csv"), uC_Halo41.GetHalo4Flow(Halo4MenuType.shoulder).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H4_Chest.csv"), uC_Halo41.GetHalo4Flow(Halo4MenuType.chest).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H4_Arms.csv"), uC_Halo41.GetHalo4Flow(Halo4MenuType.forearms).Controls); 
            CSVPuller.GetTrainerUpdater<byte>((@"H4_Legs.csv"), uC_Halo41.GetHalo4Flow(Halo4MenuType.legs).Controls);



            CSVPuller.GetTrainerUpdater<byte>((@"H4_ColourPrimary.csv"), uC_Halo41.GetHalo4Flow(Halo4MenuType.color).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"H4_ColourSecondary.csv"), uC_Halo41.GetHalo4Flow(Halo4MenuType.color).Controls);

            new TrainerUpdater<bool>(new BytesComplexBoolAdressSetter(new AdressGetter(ModuleType.halo4, 0xFD21E), new byte[] { 0x74, 0x03 }, new byte[] { nop, nop }), new TrainerBool("3rd Person Camera (Experimental)", "Use 3rd Person Camera"), uC_Halo41.GetHalo4Flow(Halo4MenuType.camera).Controls);

            //// loadouts
            ///
            // weapon and skin thingys aren't setup yet
            // idk how i would do it so ive just left it

            // CSVPuller.GetTrainerUpdater<byte>((@"H4L_Weapons.csv"), uC_Halo31.GetLoadoutFlow(Halo4LoadoutMenuType.primary1).Controls, 0x0000000);
            // CSVPuller.GetTrainerUpdater<byte>((@"H4L_Weapons.csv"), uC_Halo31.GetLoadoutFlow(Halo4LoadoutMenuType.secondary1).Controls, 0x0000000);


            CSVPuller.GetLoadoutTrainerUpdater(uC_Halo41.GetHalo4Flow(Halo4MenuType.loadout).Controls, 0x2D6B7B4 + 0x1D64);

        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          

             

            //halo2a.Enabled =  processHandler.GetModuleFromEnun(ModuleType.halo2A) != null;

            //halo4.Enabled = processHandler.GetModuleFromEnun(ModuleType.halo4) != null;
            // halo3.Enabled = processHandler.GetModuleFromEnun(ModuleType.reach) != null;
            

        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           // backgroundWorker1.RunWorkerAsync();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {

        }

        private void haloreach_Click(object sender, EventArgs e)
        {
            if (haloreach.Checked) uC_HaloReach1.BringToFront();
        }

        private void halo4_CheckedChanged(object sender, EventArgs e)
        {
            if (halo4.Checked) uC_Halo41.BringToFront();
        }

        private void halo3_CheckedChanged(object sender, EventArgs e)
        {
         //   if (h4loadouts.Checked) uC_Halo31.BringToFront();
        }

        private void halo2a_CheckedChanged(object sender, EventArgs e)
        {
            if (halo2a.Checked) uC_Halo2a1.BringToFront();
        }

        private void FlowLayout_Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void halo2a_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            if (Welcome.Checked) uC_Welcome1.BringToFront();
        }

        public delegate void ReadUIUpdate();
     public static ReadUIUpdate uIUpdate;
    }

    public class TrainerUpdater<T>
    {
        public AdressSetter<T> adressSetter;
        public UI32.ITrainerUI<T> ui;

        public TrainerUpdater(AdressSetter<T> adressSetter, ITrainerUI<T> ui, Control.ControlCollection controls)
        {
            this.adressSetter = adressSetter;
            this.ui = ui;
            controls.Add(ui as UserControl);
            ui.onValueChanged += ValueChange;
           
            ui.SetValue(Read());
            Start();

            MyForm.uIUpdate += UIUpdate;
            MyForm.shuffleTimer.Tick += ShuffleTick;
        }

        private void ShuffleTick(object sender, EventArgs e)
        {
            this.ui.AttemptShuffle();
        }

        public void Start()
        {
            
        }

        public void UIUpdate ()
        {
            ui.SetValue(Read());
        }

        public void Update()
        {


        }

        public void ValueChange(T value)
        {

            adressSetter.WriteMemory(value);

            Update();
        }

        public ITrainerUI<T> GetUI()
        {
            return ui;
        }

        public void Write()
        {
            adressSetter.WriteMemory(ui.GetValue());
        }
        public T Read()
        {
         //   
            return adressSetter.ReadMemory();
        }


    }
}


public interface IHaloUserControls<E> where E : Enum
{
     Control.ControlCollection GetControls(E numnum);
    
}
