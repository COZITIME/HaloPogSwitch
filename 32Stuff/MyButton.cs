using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UI32
{
    class MyButton : CheckBox
    {
        public MyButton()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyButton
            // 
            this.Appearance = System.Windows.Forms.Appearance.Button;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }
    }
}
