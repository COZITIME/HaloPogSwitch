using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UI32
{
  public  class MyButton : CheckBox
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
            this.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(110, 22);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }

        //public delegate void OnClick()

        //internal void Click(Action<object, object> p)
        //{
        //    throw new NotImplementedException();
        //}




        //internal void Click()
        //{

        //    OnClick.Invoke;
        //}


    }
}
