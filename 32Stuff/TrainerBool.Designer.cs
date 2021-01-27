
namespace UI32
{
    partial class TrainerBool
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
            this.CheckBox_Main = new System.Windows.Forms.CheckBox();
            this.Label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckBox_Main
            // 
            this.CheckBox_Main.AutoSize = true;
            this.CheckBox_Main.Location = new System.Drawing.Point(6, 16);
            this.CheckBox_Main.Name = "CheckBox_Main";
            this.CheckBox_Main.Size = new System.Drawing.Size(79, 17);
            this.CheckBox_Main.TabIndex = 1;
            this.CheckBox_Main.Text = "Set as Elite";
            this.CheckBox_Main.UseVisualStyleBackColor = true;
            this.CheckBox_Main.CheckedChanged += new System.EventHandler(this.CheckBox_Main_CheckedChanged_1);
            // 
            // Label_title
            // 
            this.Label_title.AutoSize = true;
            this.Label_title.Location = new System.Drawing.Point(3, 0);
            this.Label_title.Name = "Label_title";
            this.Label_title.Size = new System.Drawing.Size(75, 13);
            this.Label_title.TabIndex = 2;
            this.Label_title.Text = "Biped Speices";
            // 
            // TrainerBool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_title);
            this.Controls.Add(this.CheckBox_Main);
            this.Name = "TrainerBool";
            this.Size = new System.Drawing.Size(245, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox CheckBox_Main;
        public System.Windows.Forms.Label Label_title;
    }
}
