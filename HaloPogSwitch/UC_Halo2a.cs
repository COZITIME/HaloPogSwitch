using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloPogSwitch
{
    public partial class UC_Halo2a : UserControl, IHaloUserControls<H2ATab>
    {
        public UC_Halo2a()
        {
            InitializeComponent();
        }

        public ControlCollection GetControls(H2ATab numnum)
        {
            switch (numnum)
            {
                case H2ATab.visor:
                   
                    break;
                default:
                    break;
            }

            return flowLayoutPanel1.Controls;
        }
    }
}

public enum H2ATab
{
    visor

}
