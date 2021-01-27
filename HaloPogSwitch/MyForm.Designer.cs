﻿
namespace HaloPogSwitch
{
    partial class MyForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.siticoneShadowForm1 = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.halo2a = new Siticone.UI.WinForms.SiticoneButton();
            this.halo3 = new Siticone.UI.WinForms.SiticoneButton();
            this.halo4 = new Siticone.UI.WinForms.SiticoneButton();
            this.haloreach = new Siticone.UI.WinForms.SiticoneButton();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel3 = new Siticone.UI.WinForms.SiticonePanel();
            this.uC_HaloReach1 = new HaloPogSwitch.UC_HaloReach();
            this.uC_Halo31 = new HaloPogSwitch.UC_Halo3();
            this.uC_Halo41 = new HaloPogSwitch.UC_Halo4();
            this.uC_Halo2a1 = new HaloPogSwitch.UC_Halo2a();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.siticonePanel2.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.siticonePanel1.Controls.Add(this.pictureBox1);
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.halo2a);
            this.siticonePanel1.Controls.Add(this.halo3);
            this.siticonePanel1.Controls.Add(this.halo4);
            this.siticonePanel1.Controls.Add(this.haloreach);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Depth = 5;
            this.siticonePanel1.ShadowDecoration.Enabled = true;
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.siticonePanel1.Size = new System.Drawing.Size(142, 467);
            this.siticonePanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 305);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "HaloPogSwitch";
            // 
            // halo2a
            // 
            this.halo2a.Animated = false;
            this.halo2a.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.halo2a.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.halo2a.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.halo2a.CheckedState.Parent = this.halo2a;
            this.halo2a.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.halo2a.CustomImages.Parent = this.halo2a;
            this.halo2a.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.halo2a.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halo2a.ForeColor = System.Drawing.Color.White;
            this.halo2a.HoveredState.Parent = this.halo2a;
            this.halo2a.Image = ((System.Drawing.Image)(resources.GetObject("halo2a.Image")));
            this.halo2a.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.halo2a.Location = new System.Drawing.Point(0, 184);
            this.halo2a.Margin = new System.Windows.Forms.Padding(2);
            this.halo2a.Name = "halo2a";
            this.halo2a.PressedDepth = 0;
            this.halo2a.ShadowDecoration.Parent = this.halo2a;
            this.halo2a.Size = new System.Drawing.Size(142, 32);
            this.halo2a.TabIndex = 4;
            this.halo2a.Text = "Halo 2A";
            this.halo2a.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.halo2a.TextOffset = new System.Drawing.Point(15, 0);
            this.halo2a.CheckedChanged += new System.EventHandler(this.halo2a_CheckedChanged);
            // 
            // halo3
            // 
            this.halo3.Animated = false;
            this.halo3.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.halo3.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.halo3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.halo3.CheckedState.Parent = this.halo3;
            this.halo3.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.halo3.CustomImages.Parent = this.halo3;
            this.halo3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.halo3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halo3.ForeColor = System.Drawing.Color.White;
            this.halo3.HoveredState.Parent = this.halo3;
            this.halo3.Image = ((System.Drawing.Image)(resources.GetObject("halo3.Image")));
            this.halo3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.halo3.Location = new System.Drawing.Point(0, 152);
            this.halo3.Margin = new System.Windows.Forms.Padding(2);
            this.halo3.Name = "halo3";
            this.halo3.PressedDepth = 0;
            this.halo3.ShadowDecoration.Parent = this.halo3;
            this.halo3.Size = new System.Drawing.Size(142, 32);
            this.halo3.TabIndex = 3;
            this.halo3.Text = "Halo 3";
            this.halo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.halo3.TextOffset = new System.Drawing.Point(15, 0);
            this.halo3.CheckedChanged += new System.EventHandler(this.halo3_CheckedChanged);
            this.halo3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // halo4
            // 
            this.halo4.Animated = false;
            this.halo4.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.halo4.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.halo4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.halo4.CheckedState.Parent = this.halo4;
            this.halo4.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.halo4.CustomImages.Parent = this.halo4;
            this.halo4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.halo4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halo4.ForeColor = System.Drawing.Color.White;
            this.halo4.HoveredState.Parent = this.halo4;
            this.halo4.Image = ((System.Drawing.Image)(resources.GetObject("halo4.Image")));
            this.halo4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.halo4.Location = new System.Drawing.Point(0, 120);
            this.halo4.Margin = new System.Windows.Forms.Padding(2);
            this.halo4.Name = "halo4";
            this.halo4.PressedDepth = 0;
            this.halo4.ShadowDecoration.Parent = this.halo4;
            this.halo4.Size = new System.Drawing.Size(142, 32);
            this.halo4.TabIndex = 3;
            this.halo4.Text = "Halo 4";
            this.halo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.halo4.TextOffset = new System.Drawing.Point(15, 0);
            this.halo4.CheckedChanged += new System.EventHandler(this.halo4_CheckedChanged);
            // 
            // haloreach
            // 
            this.haloreach.Animated = false;
            this.haloreach.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.haloreach.Checked = true;
            this.haloreach.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.haloreach.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.haloreach.CheckedState.Parent = this.haloreach;
            this.haloreach.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.haloreach.CustomImages.Parent = this.haloreach;
            this.haloreach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.haloreach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haloreach.ForeColor = System.Drawing.Color.White;
            this.haloreach.HoveredState.Parent = this.haloreach;
            this.haloreach.Image = ((System.Drawing.Image)(resources.GetObject("haloreach.Image")));
            this.haloreach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.haloreach.Location = new System.Drawing.Point(0, 88);
            this.haloreach.Margin = new System.Windows.Forms.Padding(2);
            this.haloreach.Name = "haloreach";
            this.haloreach.PressedDepth = 0;
            this.haloreach.ShadowDecoration.Parent = this.haloreach;
            this.haloreach.Size = new System.Drawing.Size(142, 32);
            this.haloreach.TabIndex = 2;
            this.haloreach.Text = "Halo: Reach";
            this.haloreach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.haloreach.TextOffset = new System.Drawing.Point(15, 0);
            this.haloreach.Click += new System.EventHandler(this.haloreach_Click);
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticonePanel2.Controls.Add(this.siticoneControlBox2);
            this.siticonePanel2.Controls.Add(this.siticoneControlBox1);
            this.siticonePanel2.Location = new System.Drawing.Point(147, 0);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(526, 32);
            this.siticonePanel2.TabIndex = 5;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(459, 0);
            this.siticoneControlBox2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(34, 24);
            this.siticoneControlBox2.TabIndex = 7;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(78)))), ((int)(((byte)(73)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(493, 0);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(34, 24);
            this.siticoneControlBox1.TabIndex = 6;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticonePanel2;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticonePanel3.Controls.Add(this.uC_HaloReach1);
            this.siticonePanel3.Controls.Add(this.uC_Halo31);
            this.siticonePanel3.Controls.Add(this.uC_Halo41);
            this.siticonePanel3.Controls.Add(this.uC_Halo2a1);
            this.siticonePanel3.Location = new System.Drawing.Point(147, 37);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.ShadowDecoration.Parent = this.siticonePanel3;
            this.siticonePanel3.Size = new System.Drawing.Size(526, 430);
            this.siticonePanel3.TabIndex = 6;
            // 
            // uC_HaloReach1
            // 
            this.uC_HaloReach1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.uC_HaloReach1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_HaloReach1.Location = new System.Drawing.Point(0, 0);
            this.uC_HaloReach1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_HaloReach1.Name = "uC_HaloReach1";
            this.uC_HaloReach1.Size = new System.Drawing.Size(526, 430);
            this.uC_HaloReach1.TabIndex = 0;
            // 
            // uC_Halo31
            // 
            this.uC_Halo31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.uC_Halo31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Halo31.Location = new System.Drawing.Point(0, 0);
            this.uC_Halo31.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_Halo31.Name = "uC_Halo31";
            this.uC_Halo31.Size = new System.Drawing.Size(526, 430);
            this.uC_Halo31.TabIndex = 4;
            // 
            // uC_Halo41
            // 
            this.uC_Halo41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.uC_Halo41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Halo41.Location = new System.Drawing.Point(0, 0);
            this.uC_Halo41.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_Halo41.Name = "uC_Halo41";
            this.uC_Halo41.Size = new System.Drawing.Size(526, 430);
            this.uC_Halo41.TabIndex = 3;
            // 
            // uC_Halo2a1
            // 
            this.uC_Halo2a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.uC_Halo2a1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Halo2a1.Location = new System.Drawing.Point(0, 0);
            this.uC_Halo2a1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_Halo2a1.Name = "uC_Halo2a1";
            this.uC_Halo2a1.Size = new System.Drawing.Size(526, 430);
            this.uC_Halo2a1.TabIndex = 5;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(673, 467);
            this.Controls.Add(this.siticonePanel3);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyForm";
            this.Text = "HaloPogSwitch";
            this.Load += new System.EventHandler(this.FuckingCunt_Load);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticoneButton halo3;
        private Siticone.UI.WinForms.SiticoneButton halo4;
        private Siticone.UI.WinForms.SiticoneButton haloreach;
        private Siticone.UI.WinForms.SiticoneButton halo2a;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel3;
        private UC_HaloReach uC_HaloReach1;
        private UC_Halo3 uC_Halo31;
        private UC_Halo4 uC_Halo41;
        private System.Windows.Forms.Label label1;
        private UC_Halo2a uC_Halo2a1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

