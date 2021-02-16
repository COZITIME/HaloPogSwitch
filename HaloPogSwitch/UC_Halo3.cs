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
                case Halo4LoadoutMenuType.primary1:
                    return FlowLayout_primary1;
                case Halo4LoadoutMenuType.secondary1:
                    return FlowLayout_secondary1;
                case Halo4LoadoutMenuType.grenade1:
                    return FlowLayout_grenades1;
                case Halo4LoadoutMenuType.ability1:
                    return FlowLayout_ability1;
                case Halo4LoadoutMenuType.mod1:
                    return FlowLayout_mods1;
                case Halo4LoadoutMenuType.primary2:
                    return FlowLayout_primary2;
                case Halo4LoadoutMenuType.secondary2:
                    return FlowLayout_secondary2;
                case Halo4LoadoutMenuType.grenade2:
                    return FlowLayout_grenades2;
                case Halo4LoadoutMenuType.ability2:
                    return FlowLayout_ability2;
                case Halo4LoadoutMenuType.mod2:
                    return FlowLayout_mods2;
                case Halo4LoadoutMenuType.primary3:
                    return FlowLayout_primary3;
                case Halo4LoadoutMenuType.secondary3:
                    return FlowLayout_secondary3;
                case Halo4LoadoutMenuType.grenade3:
                    return FlowLayout_grenades3;
                case Halo4LoadoutMenuType.ability3:
                    return FlowLayout_ability3;
                case Halo4LoadoutMenuType.mod3:
                    return FlowLayout_mods3;
                case Halo4LoadoutMenuType.primary4:
                    return FlowLayout_primary4;
                case Halo4LoadoutMenuType.secondary4:
                    return FlowLayout_secondary4;
                case Halo4LoadoutMenuType.grenade4:
                    return FlowLayout_grenades4;
                case Halo4LoadoutMenuType.ability4:
                    return FlowLayout_ability4;
                case Halo4LoadoutMenuType.mod4:
                    return FlowLayout_mods4;
                case Halo4LoadoutMenuType.primary5:
                    return FlowLayout_primary5;
                case Halo4LoadoutMenuType.secondary5:
                    return FlowLayout_secondary5;
                case Halo4LoadoutMenuType.grenade5:
                    return FlowLayout_grenades5;
                case Halo4LoadoutMenuType.ability5:
                    return FlowLayout_ability5;
                case Halo4LoadoutMenuType.mod5:
                    return FlowLayout_mods5;
                default:
                    return null;
            }
        }
    }



    public enum Halo4LoadoutMenuType
    {
        primary1,
        secondary1,
        grenade1,
        ability1,
        mod1,
        primary2,
        secondary2,
        grenade2,
        ability2,
        mod2,
        primary3,
        secondary3,
        grenade3,
        ability3,
        mod3,
        primary4,
        secondary4,
        grenade4,
        ability4,
        mod4,
        primary5,
        secondary5,
        grenade5,
        ability5,
        mod5,

    }
}
