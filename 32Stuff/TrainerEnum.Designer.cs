
namespace UI32
{
    partial class TrainerEnum
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label_title
            // 
            this.Label_title.AutoSize = true;
            this.Label_title.Location = new System.Drawing.Point(3, 4);
            this.Label_title.Name = "Label_title";
            this.Label_title.Size = new System.Drawing.Size(75, 13);
            this.Label_title.TabIndex = 3;
            this.Label_title.Text = "Biped Speices";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(6, 29);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(345, 108);
            this.ListBox.TabIndex = 4;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // TrainerEnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.Label_title);
            this.Name = "TrainerEnum";
            this.Size = new System.Drawing.Size(362, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label_title;
        private System.Windows.Forms.ListBox ListBox;
    }
}
