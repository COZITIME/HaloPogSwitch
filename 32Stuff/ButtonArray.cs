using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
namespace HaloPogSwitch
{
    using UI32;
    public partial class ButtonArray : UserControl
    {
        public ButtonArray(string text)
        {
           
            InitializeComponent();
            groupBox1.Text = text;
        }

        internal ControlCollection GetControlls()
        {
            return flowLayoutPanel1.Controls;
        }
    }
}
