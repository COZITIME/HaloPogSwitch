using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI32
{
    public partial class TrainerNumeric : UserControl, ITrainerUI<short>
        {

        short val;

        public TrainerNumeric(string title, string main)
        {
            InitializeComponent();
            Label_title.Text = title;
            Label_main.Text = main;
           
        }

        public short GetValue()
        {

            return val;
        }

        public void SetValue(short value)
        {
            val = value;
            numericUpDown1.Value = value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            val = (short) numericUpDown1.Value;

            onValueChanged?.Invoke(GetValue());
        }



        bool allowDecimal = false;

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (allowDecimal || !regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }          
        }

        Regex regex = new Regex(@"[^.]");

        public ValueChanged<short> onValueChanged { get; set; }

        private void numericUpDown1_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        public void AttemptShuffle()
        {
            
        }
    }
}
