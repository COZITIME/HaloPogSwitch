using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI32
{
 


    public partial class TrainerBool : UserControl, ITrainerUI<bool>
    {
      

        public TrainerBool(string title, string checkboxLabel)
        {
            InitializeComponent();

            Label_title.Text = title;
            CheckBox_Main.Text = checkboxLabel;
        }

        

    

      
        public bool GetValue()
        {
            return CheckBox_Main.Checked;
        }

        public void SetValue(bool value)
        {
            CheckBox_Main.Checked = value;
        }


        public ValueChanged<bool> onValueChanged { get; set; }

        private void CheckBox_Main_CheckedChanged_1(object sender, EventArgs e)
        {
            onValueChanged.Invoke(CheckBox_Main.Checked);
        }

        public void AttemptShuffle()
        {
           // SetValue(!CheckBox_Main.Checked);
        }
    }



}
