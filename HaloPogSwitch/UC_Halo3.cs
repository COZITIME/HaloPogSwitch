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
    public partial class UC_Halo3 : UserControl
    {
        public UC_Halo3()
        {
            InitializeComponent();
        }

        public FlowLayoutPanel GetLoadoutFlow(Halo4LoadoutMenuType type)
        {
            switch (type)
            {
                case Halo4LoadoutMenuType.camera:
                    return FlowLayout_Camera;
                default:
                    return null;
            }
        }
    }



    public enum Halo4LoadoutMenuType
    {
       camera
    }
}
