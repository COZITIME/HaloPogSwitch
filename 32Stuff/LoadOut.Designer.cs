
namespace UI32
{
    partial class LoadOut
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
            this.WeaponPrimary = new System.Windows.Forms.ComboBox();
            this.SkinPrimaryWeapon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asa = new System.Windows.Forms.Label();
            this.WeaponSecondary = new System.Windows.Forms.ComboBox();
            this.SkinSecondaryWeapon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.Label();
            this.Ablity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Grenade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Mod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LoadoutNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadoutNum)).BeginInit();
            this.SuspendLayout();
            // 
            // WeaponPrimary
            // 
            this.WeaponPrimary.FormattingEnabled = true;
            this.WeaponPrimary.Location = new System.Drawing.Point(128, 43);
            this.WeaponPrimary.Name = "WeaponPrimary";
            this.WeaponPrimary.Size = new System.Drawing.Size(121, 21);
            this.WeaponPrimary.TabIndex = 0;
            this.WeaponPrimary.SelectedIndexChanged += new System.EventHandler(this.PrimaryChange);
            // 
            // SkinPrimaryWeapon
            // 
            this.SkinPrimaryWeapon.FormattingEnabled = true;
            this.SkinPrimaryWeapon.Location = new System.Drawing.Point(387, 43);
            this.SkinPrimaryWeapon.Name = "SkinPrimaryWeapon";
            this.SkinPrimaryWeapon.Size = new System.Drawing.Size(121, 21);
            this.SkinPrimaryWeapon.TabIndex = 0;
            this.SkinPrimaryWeapon.SelectedIndexChanged += new System.EventHandler(this.UIUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primary Weapon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // asa
            // 
            this.asa.Location = new System.Drawing.Point(272, 46);
            this.asa.Name = "asa";
            this.asa.Size = new System.Drawing.Size(109, 13);
            this.asa.TabIndex = 1;
            this.asa.Text = "Primary Weapon Skin";
            this.asa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeaponSecondary
            // 
            this.WeaponSecondary.FormattingEnabled = true;
            this.WeaponSecondary.Location = new System.Drawing.Point(128, 67);
            this.WeaponSecondary.Name = "WeaponSecondary";
            this.WeaponSecondary.Size = new System.Drawing.Size(121, 21);
            this.WeaponSecondary.TabIndex = 0;
            this.WeaponSecondary.SelectedIndexChanged += new System.EventHandler(this.SecondaryChange);
            // 
            // SkinSecondaryWeapon
            // 
            this.SkinSecondaryWeapon.FormattingEnabled = true;
            this.SkinSecondaryWeapon.Location = new System.Drawing.Point(387, 67);
            this.SkinSecondaryWeapon.Name = "SkinSecondaryWeapon";
            this.SkinSecondaryWeapon.Size = new System.Drawing.Size(121, 21);
            this.SkinSecondaryWeapon.TabIndex = 0;
            this.SkinSecondaryWeapon.SelectedIndexChanged += new System.EventHandler(this.UIUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secondary Weapon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Location = new System.Drawing.Point(255, 70);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(126, 13);
            this.ss.TabIndex = 1;
            this.ss.Text = "Secondary Weapon Skin";
            this.ss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ablity
            // 
            this.Ablity.FormattingEnabled = true;
            this.Ablity.Location = new System.Drawing.Point(95, 109);
            this.Ablity.Name = "Ablity";
            this.Ablity.Size = new System.Drawing.Size(154, 21);
            this.Ablity.TabIndex = 0;
            this.Ablity.SelectedIndexChanged += new System.EventHandler(this.UIUpdate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ability";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Grenade
            // 
            this.Grenade.FormattingEnabled = true;
            this.Grenade.Location = new System.Drawing.Point(95, 136);
            this.Grenade.Name = "Grenade";
            this.Grenade.Size = new System.Drawing.Size(154, 21);
            this.Grenade.TabIndex = 0;
            this.Grenade.SelectedIndexChanged += new System.EventHandler(this.UIUpdate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Grenade";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mod
            // 
            this.Mod.FormattingEnabled = true;
            this.Mod.Location = new System.Drawing.Point(95, 163);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(154, 21);
            this.Mod.TabIndex = 0;
            this.Mod.SelectedIndexChanged += new System.EventHandler(this.UIUpdate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Armour Mod";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoadoutNum
            // 
            this.LoadoutNum.Location = new System.Drawing.Point(177, 9);
            this.LoadoutNum.Name = "LoadoutNum";
            this.LoadoutNum.Size = new System.Drawing.Size(32, 20);
            this.LoadoutNum.TabIndex = 2;
            this.LoadoutNum.ValueChanged += new System.EventHandler(this.LoadoutNum_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Loadout";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(275, 8);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(128, 20);
            this.NameBox.TabIndex = 3;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoadOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.LoadoutNum);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asa);
            this.Controls.Add(this.SkinSecondaryWeapon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeaponSecondary);
            this.Controls.Add(this.SkinPrimaryWeapon);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Grenade);
            this.Controls.Add(this.Ablity);
            this.Controls.Add(this.WeaponPrimary);
            this.Name = "LoadOut";
            this.Size = new System.Drawing.Size(545, 203);
            this.Load += new System.EventHandler(this.LoadOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadoutNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox WeaponPrimary;
        private System.Windows.Forms.ComboBox SkinPrimaryWeapon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label asa;
        private System.Windows.Forms.ComboBox WeaponSecondary;
        private System.Windows.Forms.ComboBox SkinSecondaryWeapon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.ComboBox Ablity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Grenade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Mod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown LoadoutNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label9;
    }
}
