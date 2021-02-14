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
    public partial class UC_Halo4 : UserControl
    {
        public UC_Halo4()
        {
            InitializeComponent();
        }


        public FlowLayoutPanel GetReachFlow(Halo4MenuType type)
        {
            switch (type)
            {
                case Halo4MenuType.helmateVisor:
                    return FlowLayout_Helmet;
                case Halo4MenuType.chest:
                    return FlowLayout_Chest;
                case Halo4MenuType.shoulder:
                    return FlowLayout_Shoulder;
                case Halo4MenuType.forearms:
                    return FlowLayout_Forearms;
                case Halo4MenuType.legs:
                    return FlowLayout_Leg;

                case Halo4MenuType.serviceid:
                    return FlowLayout_ServiceID;
                case Halo4MenuType.color:
                    return FlowLayout_Color;

                case Halo4MenuType.gender:
                    return FlowLayout_Gender;

                default:
                    return null;
            }
        }

        public enum Halo4MenuType
        {
            helmateVisor,
            shoulder,
            chest,
            forearms,
            legs,

            color,

            gender,
            serviceid,


        }

    }
}
