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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.FlatAppearance.BorderSize = 2;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(140, 30);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }
    }
}
