using HaloPogSwitch.Stuff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI32;

namespace HaloPogSwitch
{
    public partial class MyForm : Form
    {



        public ProcessEditorHandler processHandler = new ProcessEditorHandler();

        public MyForm()
        {
            InitializeComponent();
        }

        private void FuckingCunt_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);

            //var helmateEnumUi = CSVPuller.GetTrainerEnumFromFile(@"C:\Users\Magic\source\repos\HaloPogSwitch\Data\Reach_Helm.csv");

            processHandler.GetMemory();


            // controls for where we instatiate the uis


            // Adress Value setters Linked to UI so they update automatically
            new TrainerUpdater<string>(new StringAdressSetter(new AdressGetter(ModuleType.reach, 0x27E13C4), 4), new TrainerText("Service Tag", "4 Letter Tag:", 4, true, CharacterCasing.Upper, true), uC_HaloReach1.GetFlow(HaloReachMenuType.extra).Controls);
            new TrainerUpdater<bool>(new BoolAdressSetter(new AdressGetter(ModuleType.reach, 0x27E13A4)), new TrainerBool("Species", "Elite Biped"), uC_HaloReach1.GetFlow(HaloReachMenuType.species).Controls);
            new TrainerUpdater<bool>(new ComplexBoolAdressSetter(new AdressGetter(ModuleType.reach, 0x27E1208), 0x18, 0x38), new TrainerBool("Spartan Gender", "Is Female"), uC_HaloReach1.GetFlow(HaloReachMenuType.extra).Controls);

            new TrainerUpdater<byte>(new ByteAdressSetter(new AdressGetter(ModuleType.reach, 0x27E13B1)), CSVPuller.GetTrainerEnumFromFile(@"data\Reach_Chest.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.chest).Controls);
            //CSVPuller.GetTrainerUpdater<byte>((@"Reach_ColourPrimary.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.extra).Controls);
            //CSVPuller.GetTrainerUpdater<byte>((@"Reach_ColourSecondary.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.extra).Controls);

            // Also a bunch of Trainer Updaers - These use the CVS puller to get automatically created by the CVS files (seen on the google sheets)
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Helmate.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.helmateVisor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Visor.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.helmateVisor).Controls);
            // CSVPuller.GetTrainerUpdater<byte>((@"Reach_Chest.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.chest).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_LeftShoulder.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.shoulder).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_RightShoulder.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.shoulder).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Wrist.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.wrist).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Utility.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.utility).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_Kneepad.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.knees).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_ArmorEffect.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.armoreffects).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_EliteArmor.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.elitearmor).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_EliteEffects.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.elitearmor).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_ColourPrimary.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.colour).Controls);
            CSVPuller.GetTrainerUpdater<byte>((@"Reach_ColourSecondary.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.colour).Controls);

            CSVPuller.GetTrainerUpdater<byte>((@"Reach_FireFightVoice.csv"), uC_HaloReach1.GetFlow(HaloReachMenuType.extra).Controls);




            //C_HaloReach1.GetFlow(HaloReachMenuType.colour).Controls.Add(new TrainerEnumNestedButtonHolder());
            //CSVPuller.GetTrainerUpdater<byte>((@"H2A_ColourPrimary.csv"), uC_Halo2a1.GetControls(H2ATab.visor));
            //CSVPuller.GetTrainerUpdater<byte>((@"H2A_ColourSecondary.csv"), uC_Halo2a1.GetControls(H2ATab.visor));

            //// Halo 2A
            //CSVPuller.GetTrainerUpdater<byte>((@"H2A_Helmates.csv"), uC_Halo2a1.GetControls(H2ATab.visor));
            //CSVPuller.GetTrainerUpdater<byte>((@"H2A_Visors.csv"), uC_Halo2a1.GetControls(H2ATab.visor));
            //CSVPuller.GetTrainerUpdater<byte>((@"H2A_Chest.csv"), uC_Halo2a1.GetControls(H2ATab.visor));
            //CSVPuller.GetTrainerUpdater<byte>((@"H2A_Arms.csv"), uC_Halo2a1.GetControls(H2ATab.visor));
            //CSVPuller.GetTrainerUpdater<byte>((@"H2A_Legs.csv"), uC_Halo2a1.GetControls(H2ATab.visor));
            //CSVPuller.GetTrainerUpdater<byte>((@"H2A_LShoulder.csv"), uC_Halo2a1.GetControls(H2ATab.visor));
            //CSVPuller.GetTrainerUpdater<byte>((@"H2A_RShoulder.csv"), uC_Halo2a1.GetControls(H2ATab.visor));

        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(50);
            processHandler.UpdateProcess();

        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
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
            if (halo3.Checked) uC_Halo31.BringToFront();
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
    }

    public class TrainerUpdater<T>
    {
        public AdressSetter<T> adressSetter;
        public UI32.TrainerUI<T> ui;

        public TrainerUpdater(AdressSetter<T> adressSetter, TrainerUI<T> ui, Control.ControlCollection controls)
        {
            this.adressSetter = adressSetter;
            this.ui = ui;
            controls.Add(ui as UserControl);
            ui.onValueChanged += ValueChange;
           
            ui.SetValue(Read());
            Start();
        }

        public void Start()
        {
            
        }

        public void Update()
        {


        }

        public void ValueChange(T value)
        {

            adressSetter.WriteMemory(value);

            Update();
        }

        public TrainerUI<T> GetUI()
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
    public Control.ControlCollection GetControls(E numnum);
    
}
