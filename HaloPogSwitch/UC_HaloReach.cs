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
                case HaloReachMenuType.serviceid:
                    return FlowLayout_ServiceID;
                case HaloReachMenuType.color:
                    return FlowLayout_Color;
                case HaloReachMenuType.armoreffects:
                    return FlowLayout_ArmorEffects;
                case HaloReachMenuType.elitearmor:
                    return FlowLayout_EliteArmor;
                case HaloReachMenuType.species:
                    return FlowLayout_Species;
                case HaloReachMenuType.gender:
                    return FlowLayout_Gender;
                case HaloReachMenuType.eliteeffects:
                    return FlowLayout_EliteEffects;
                case HaloReachMenuType.firefightvoice:
                    return FlowLayout_FirefightVoice;
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
        color,
        armoreffects,
        eliteeffects,
        elitearmor,
        species,
        gender,
        serviceid,
        firefightvoice,

    }

}
