﻿
namespace UI32
{
    partial class TrainerText
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
            this.label_main = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.LoopBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Label_title
            // 
            this.Label_title.AutoSize = true;
            this.Label_title.Location = new System.Drawing.Point(3, 3);
            this.Label_title.Name = "Label_title";
            this.Label_title.Size = new System.Drawing.Size(75, 13);
            this.Label_title.TabIndex = 4;
            this.Label_title.Text = "Biped Speices";
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Location = new System.Drawing.Point(3, 23);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(75, 13);
            this.label_main.TabIndex = 4;
            this.label_main.Text = "Biped Speices";
            this.label_main.Click += new System.EventHandler(this.label_main_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(84, 20);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 5;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // LoopBox
            // 
            this.LoopBox.AutoSize = true;
            this.LoopBox.Location = new System.Drawing.Point(118, 2);
            this.LoopBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LoopBox.Name = "LoopBox";
            this.LoopBox.Size = new System.Drawing.Size(66, 17);
            this.LoopBox.TabIndex = 6;
            this.LoopBox.Text = "Random";
            this.LoopBox.UseVisualStyleBackColor = true;
            // 
            // TrainerText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoopBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label_main);
            this.Controls.Add(this.Label_title);
            this.Name = "TrainerText";
            this.Size = new System.Drawing.Size(197, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label_title;
        public System.Windows.Forms.Label label_main;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox LoopBox;
    }
}
