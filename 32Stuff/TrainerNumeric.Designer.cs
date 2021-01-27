
namespace UI32
{
    partial class TrainerNumeric
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_title = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Label_main = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_title
            // 
            this.Label_title.AutoSize = true;
            this.Label_title.Location = new System.Drawing.Point(3, 0);
            this.Label_title.Name = "Label_title";
            this.Label_title.Size = new System.Drawing.Size(75, 13);
            this.Label_title.TabIndex = 3;
            this.Label_title.Text = "Biped Speices";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(46, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.VisibleChanged += new System.EventHandler(this.numericUpDown1_VisibleChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // Label_main
            // 
            this.Label_main.AutoSize = true;
            this.Label_main.Location = new System.Drawing.Point(3, 18);
            this.Label_main.Name = "Label_main";
            this.Label_main.Size = new System.Drawing.Size(37, 13);
            this.Label_main.TabIndex = 3;
            this.Label_main.Text = "Value:";
            // 
            // TrainerNumeric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Label_main);
            this.Controls.Add(this.Label_title);
            this.Name = "TrainerNumeric";
            this.Size = new System.Drawing.Size(134, 45);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label_title;
        public System.Windows.Forms.Label Label_main;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
