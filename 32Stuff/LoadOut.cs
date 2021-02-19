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
    public partial class LoadOut : UserControl, ITrainerUI<LoadoutData>
    {

        LoudoutUIData uiData;




        public LoadOut(LoudoutUIData loudoutUIData)
        {
            InitializeComponent();

            uiData = loudoutUIData;

            foreach (var item in uiData.weapon.weapons)
            {
                WeaponPrimary.Items.Add(item.Value.weaponName);
                WeaponSecondary.Items.Add(item.Value.weaponName);
            }


            foreach (var item in uiData.ablities)
            {
                Ablity.Items.Add(item.Value);
            }
            foreach (var item in uiData.mods)
            {
                Mod.Items.Add(item.Value);
            }
            foreach (var item in uiData.grenades)
            {
                Grenade.Items.Add(item.Value);
            }

        }


        public class LoudoutUIData
        {
            public WeaponUiData weapon;

            public SortedList<byte, string> ablities;
            public SortedList<byte, string> mods;
            public SortedList<byte, string> grenades;

            public LoudoutUIData(WeaponUiData weapon, SortedList<byte, string> ablities, SortedList<byte, string> mods, SortedList<byte, string> grenades)
            {
                this.weapon = weapon;

                this.ablities = ablities;
                this.mods = mods;
                this.grenades = grenades;
            }


        }


        public struct WeaponUiData
        {
            public SortedList<byte, WeaponSkinUiData> weapons;

            public struct WeaponSkinUiData
            {
                public string weaponName;
                public SortedList<byte, string> skins;

            }
        }



        public ValueChanged<LoadoutData> onValueChanged { get; set; }

        public LoadOut()
        {
            InitializeComponent();
        }

        private void LoadOut_Load(object sender, EventArgs e)
        {

        }


        public LoadoutData GetValue()
        {
            return data;
        }

        public void SetValue(LoadoutData value)
        {
            data = value;
            UpdateUI();
        }


        public void UpdateUI()
        {
            NameBox.Text = data.name;

            WeaponPrimary.TabIndex = data.primary.weapon;
            SkinPrimaryWeapon.TabIndex = data.primary.skin;

            WeaponSecondary.TabIndex = data.secondary.weapon;
            SkinSecondaryWeapon.TabIndex = data.secondary.weapon;

            Ablity.TabIndex = data.ability;
            Grenade.TabIndex = data.grenade;
            Mod.TabIndex = data.mod;


        }

        public void AttemptShuffle()
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            SetLoadoutData();
        }

        private void LoadoutNum_ValueChanged(object sender, EventArgs e)
        {
            SetLoadoutData();
        }

        private void UIUpdate(object sender, EventArgs e)
        {

            SetLoadoutData();
        }

        LoadoutData data;

        public void SetLoadoutData()
        {

            LoadoutData newData = new LoadoutData(NameBox.Text, WeaponPrimary.TabIndex, SkinPrimaryWeapon.TabIndex, WeaponSecondary.TabIndex, SkinSecondaryWeapon.TabIndex, Ablity.TabIndex, Mod.TabIndex, Grenade.TabIndex);

            if (data == null) data = newData;

            if (newData.primary.weapon != data.primary.weapon)
            {
                SkinPrimaryWeapon.Items.Clear();

                foreach (var item in uiData.weapon.weapons.ElementAt(1).Value.skins)
                {
                    SkinPrimaryWeapon.Items.Add(item.Value);
                }

            }


            if (newData.secondary.weapon != data.secondary.weapon)
            {
                SkinSecondaryWeapon.Items.Clear();

                foreach (var item in uiData.weapon.weapons.ElementAt(1).Value.skins)
                {
                    SkinSecondaryWeapon.Items.Add(item.Value);
                }

            }

            data = newData;

            //onValueChanged(data);
        }
    }


    public class LoadoutData
    {
        public string name;
        public Weapon primary, secondary;

        public byte ability, mod, grenade;

        public LoadoutData(string text, int pw, int pws, int sw, int sws, int a, int m, int g)
        {
            this.name = text;
            this.primary = new Weapon((byte)pw, (byte)pws);
            this.secondary = new Weapon((byte)sw, (byte)pws);
            this.ability = (byte)a;
            this.mod = (byte)m;
            this.grenade = (byte)g;
        }

        public struct Weapon
        {
            public byte weapon;
            public byte skin;

            public Weapon(byte weapon, byte skin)
            {
                this.weapon = weapon;
                this.skin = skin;
            }
        }

        public string GetWeaponName(Weapon weapon)
        {
            return "Weapon: " + weapon;
        }




    }
}
