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
        LoadoutData data;

        public delegate void IndexChangeUpdate(LoadoutData newData);
        public static IndexChangeUpdate dataUpdate;

        public LoadOut(LoudoutUIData loudoutUIData)
        {
            InitializeComponent();

            LoadoutNum.Minimum = 1;
            LoadoutNum.Maximum = 5;

            uiData = loudoutUIData;

            foreach (var item in uiData.weapon.weapons)
            {
                WeaponPrimary.Items.Add(item.Value);
                WeaponSecondary.Items.Add(item.Value);

                indexedWeapons.Add(item);
            }

            foreach (var item in uiData.ablities)
            {


                Ablity.Items.Add(item.Value);
                indexedAbilites.Add(item);
            }
            foreach (var item in uiData.mods)
            {
                Mod0.Items.Add(item.Value);
                Mod1.Items.Add(item.Value);

                indexedMods.Add(item);
            }
            foreach (var item in uiData.grenades)
            {
                Grenade.Items.Add(item.Value);
                indexedGrenades.Add(item);
            }

            dataUpdate += SetValue;

        }


        public List<KeyValuePair<byte, string>> indexedAbilites = new List<KeyValuePair<byte, string>>();
        public List<KeyValuePair<byte, string>> indexedMods = new List<KeyValuePair<byte, string>>();
        public List<KeyValuePair<byte, string>> indexedGrenades = new List<KeyValuePair<byte, string>>();

        public List<KeyValuePair<byte, WeaponUiData.WeaponSkinUiData>> indexedWeapons = new List<KeyValuePair<byte, WeaponUiData.WeaponSkinUiData>>();


        //public void UpdateData(LoadoutData loadoutData)
        //{
        //    SetValue(loadoutData);
        //}

        public List<KeyValuePair<byte, string>> indexPrimarySkins = new List<KeyValuePair<byte, string>>();
        public List<KeyValuePair<byte, string>> indexSecondarySkins = new List<KeyValuePair<byte, string>>();

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

                public override string ToString()
                {
                    return weaponName;
                }

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


        bool ignorestuff = false;

        public void UpdateUI()
        {
            byte skinDataP = data.primary.skin;
            byte skinDataS = data.secondary.skin;

            ignorestuff = true;
            NameBox.Text = data.name;

            WeaponPrimary.SelectedIndex = indexedWeapons.IndexOf(indexedWeapons.FirstOrDefault(w => w.Key == data.primary.weapon));
            WeaponSecondary.SelectedIndex = indexedWeapons.IndexOf(indexedWeapons.FirstOrDefault(w => w.Key == data.secondary.weapon));
            

            Ablity.SelectedIndex = indexedAbilites.IndexOf(indexedAbilites.FirstOrDefault(a => a.Key == data.ability));
            Mod0.SelectedIndex = indexedMods.IndexOf(indexedMods.FirstOrDefault(a => a.Key == data.mod0));
            Mod1.SelectedIndex = indexedMods.IndexOf(indexedMods.FirstOrDefault(a => a.Key == data.mod1));
            Grenade.SelectedIndex = indexedGrenades.IndexOf(indexedGrenades.FirstOrDefault(a => a.Key == data.grenade));


            SkinPrimaryWeapon.SelectedIndex = indexPrimarySkins.IndexOf(indexPrimarySkins.FirstOrDefault(a => a.Key == data.primary.skin));
            SkinSecondaryWeapon.SelectedIndex = indexSecondarySkins.IndexOf(indexSecondarySkins.FirstOrDefault(a => a.Key == data.secondary.skin));

            ignorestuff = false;

            UpdateSkin(false);
            UpdateSkin(true);

            ignorestuff = true;

            data.primary.skin = skinDataP;
            data.secondary.skin = skinDataS;

            SkinPrimaryWeapon.SelectedIndex = indexPrimarySkins.IndexOf(indexPrimarySkins.FirstOrDefault(a => a.Key == data.primary.skin));
            SkinSecondaryWeapon.SelectedIndex = indexSecondarySkins.IndexOf(indexSecondarySkins.FirstOrDefault(a => a.Key == data.secondary.skin));



            ignorestuff = false;
        }

        public void AttemptShuffle()
        {

        }


        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            data.name = NameBox.Text;
            onValueChanged(data);
        }

        private void LoadoutNum_ValueChanged(object sender, EventArgs e)
        {
            int loadoutIndex = (int)LoadoutNum.Value - 1;
            ichange.Invoke(loadoutIndex);
        }


        public void SetAllDataFromUI()
        {
            

            //if (indexedWeapons.Count == 0) return;

            LoadoutData newData = new LoadoutData(NameBox.Text,
                indexedWeapons[WeaponPrimary.SelectedIndex].Key,
                indexPrimarySkins[SkinPrimaryWeapon.SelectedIndex].Key,
                indexedWeapons[WeaponSecondary.SelectedIndex].Key,
                indexSecondarySkins[SkinSecondaryWeapon.SelectedIndex].Key,
                indexedAbilites[Ablity.SelectedIndex].Key,
                indexedMods[Mod0.SelectedIndex].Key,
                 indexedMods[Mod1.SelectedIndex].Key,
                indexedGrenades[Grenade.SelectedIndex].Key);

            data = newData;
         
            onValueChanged.Invoke(newData);
        }

       

        private void UpdateData<T>(List<KeyValuePair<byte, T>> indexedWeapons, int selectedIndex, ref byte dataCat)
        {
           
            if (selectedIndex != -1 && indexedWeapons.Count > (selectedIndex))
            {
                
                dataCat = indexedWeapons[selectedIndex].Key;
                onValueChanged.Invoke(data);
            } 
        }
      

        public void UpdateSkin(bool secondary)
        {
            if (ignorestuff) return;

            var weaponUi = secondary ? WeaponSecondary : WeaponPrimary;
            var skinUi = secondary ? SkinSecondaryWeapon : SkinPrimaryWeapon;
            var indexedSkins = secondary ? indexSecondarySkins : indexPrimarySkins;

           

            int wepindex = weaponUi.SelectedIndex;
            SortedList<byte, string> skins = indexedWeapons[wepindex].Value.skins;

            skinUi.Items.Clear();
            indexedSkins.Clear();

            foreach (var item in skins)
            {
                skinUi.Items.Add(item);
                indexedSkins.Add(item);
            }
            skinUi.SelectedIndex = 0;


            if (secondary)
            {
                UpdateData(indexedSkins, skinUi.SelectedIndex, ref data.secondary.skin);
            }
            else
            {
                UpdateData(indexedSkins, skinUi.SelectedIndex, ref data.primary.skin);
            }

        }


        public delegate void IndexChange(int index);
        public static IndexChange ichange;


        private void PrimeSkinChange(object sender, EventArgs e)
        {
            UpdateData(indexPrimarySkins, SkinPrimaryWeapon.SelectedIndex, ref data.primary.skin);
        }

        private void SecSkinChange(object sender, EventArgs e)
        {
           
            UpdateData(indexSecondarySkins, SkinSecondaryWeapon.SelectedIndex, ref data.secondary.skin);
        }

        private void AbilitySelect(object sender, EventArgs e)
        {
            UpdateData(indexedAbilites, Ablity.SelectedIndex, ref data.ability);
          
        }

        private void GrenSelect(object sender, EventArgs e)
        {
            UpdateData(indexedGrenades, Grenade.SelectedIndex, ref data.grenade);
        }

        private void ModaSelect(object sender, EventArgs e)
        {

            UpdateData(indexedMods, Mod0.SelectedIndex, ref data.mod0);
            
        }

        private void ModbSelect(object sender, EventArgs e)
        {
            UpdateData(indexedMods, Mod1.SelectedIndex, ref data.mod1);
        }

        private void PrimaryChange(object sender, EventArgs e)
        {
            
            UpdateData(indexedWeapons, WeaponPrimary.SelectedIndex, ref data.primary.weapon);
            if (!ignorestuff) UpdateSkin(false);

            // SkinPrimaryWeapon.SelectedIndex = indexPrimarySkins.IndexOf(indexPrimarySkins.FirstOrDefault(a => a.Key == data.primary.skin));
        }

        private void SecondaryChange(object sender, EventArgs e)
        {
           
            UpdateData(indexedWeapons, WeaponSecondary.SelectedIndex, ref data.secondary.weapon);
            if (!ignorestuff) UpdateSkin(true);


            // SkinSecondaryWeapon.SelectedIndex = indexSecondarySkins.IndexOf(indexSecondarySkins.FirstOrDefault(a => a.Key == data.secondary.skin));

        }
    }



    public class LoadoutData
    {
        public string name;
        public Weapon primary, secondary;

        public byte ability, mod0, mod1, grenade;

        public LoadoutData(string text, byte pw, byte pws, byte sw, byte sws, byte a, byte g, byte m0, byte m1)
        {
            this.name = text;
            this.primary = new Weapon((byte)pw, (byte)pws);
            this.secondary = new Weapon((byte)sw, (byte)sws);
            this.ability = (byte)a;

            this.grenade = (byte)g;

            mod0 = m0;
            mod1 = m1;
        }




        //public LoadoutData(string text, int pw, int pws, int sw, int sws, int a, int m, int g)
        //{
        //    this.name = text;
        //    this.primary = new Weapon((byte)pw, (byte)pws);
        //    this.secondary = new Weapon((byte)sw, (byte)pws);
        //    this.ability = (byte)a;
        //    this.mod = (byte)m;
        //    this.grenade = (byte)g;
        //}

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
