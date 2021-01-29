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
    public partial class TrainerEnumNestedButtonHolder : UserControl
    {
        public TrainerEnumNestedButtonHolder()
        {
            InitializeComponent();


            for (int i = 0; i < 4; i++)
            {
                Control con = new Control();
                var butt = new MyButton();
                butt.Text = "Butt "+ i;
                tableLayoutPanel1.SetRow(butt, 0);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
