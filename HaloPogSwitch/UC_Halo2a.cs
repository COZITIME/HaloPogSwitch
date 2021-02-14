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
    public partial class UC_Halo2a : UserControl
    {
        public UC_Halo2a()
        {
            InitializeComponent();
        }

        public FlowLayoutPanel GetHalo2AFlow(H2ATab numnum)
        {
            switch (numnum)
            {
                case H2ATab.helmateVisor:
                    return FlowLayout_Helmet;
                case H2ATab.chest:
                    return FlowLayout_Chest;
                case H2ATab.shoulder:
                    return FlowLayout_Shoulder;
                case H2ATab.wrist:
                    return FlowLayout_Wrist;
                case H2ATab.knees:
                    return FlowLayout_Knee;
                case H2ATab.serviceid:
                    return FlowLayout_ServiceID;
                case H2ATab.color:
                    return FlowLayout_Color;
                case H2ATab.elitearmor:
                    return FlowLayout_EliteArmor;
                case H2ATab.species:
                    return FlowLayout_Species;
                case H2ATab.gender:
                    return FlowLayout_Gender;
                default:
                    return null;
            }
        }

        private void UC_Halo2a_Load(object sender, EventArgs e)
        {

        }
    }
}

public enum H2ATab
{
    helmateVisor,
    shoulder,
    chest,
    wrist,
    knees,
    color,
    elitearmor,
    species,
    gender,
    serviceid,

}
