using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloPogSwitch
{
    public partial class UC_HaloReach : UserControl
    {
        public UC_HaloReach()
        {
            InitializeComponent();
        }

        public FlowLayoutPanel GetFlow (HaloReachMenuType type )
        {
            switch (type)
            {
                case HaloReachMenuType.helmateVisor:
                    return FlowLayout_Helmet;
                case HaloReachMenuType.chest:
                    return FlowLayout_Chest;
                case HaloReachMenuType.shoulder:
                    return FlowLayout_Shoulder;
                case HaloReachMenuType.wrist:
                    return FlowLayout_Wrist;
                case HaloReachMenuType.knees:
                    return FlowLayout_Knee;
                case HaloReachMenuType.utility:
                    return FlowLayout_Utility;
                case HaloReachMenuType.extra:
                    return FlowLayout_Extra;
                case HaloReachMenuType.colour:
                    return FlowLayout_Colour;
                case HaloReachMenuType.armoreffects:
                    return FlowLayout_ArmorEffects;
                case HaloReachMenuType.elitearmor:
                    return FlowLayout_EliteArmor;
                case HaloReachMenuType.species:
                    return FlowLayout_Species;
                default:
                    return null;
            }
        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_HaloReach_Load(object sender, EventArgs e)
        {

        }

        private void UC_HaloReach_Load_1(object sender, EventArgs e)
        {

        }
    }


    public enum HaloReachMenuType
    {
        helmateVisor,
        shoulder,
        chest,
        wrist,
        knees,
        utility,
        colour,
        armoreffects,
        elitearmor,
        species,
        extra,

    }

}
