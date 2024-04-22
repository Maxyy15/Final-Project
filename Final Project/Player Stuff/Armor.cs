using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Player_Stuff
{
    internal class Armor
    {
        public string armorName;
        public int damageReduction;
        public int armorCost;
        public bool isBoughtArmor;

        public Armor(string armorName, int damageReduction, int armorCost, bool bought)
        {
            this.armorName = armorName;
            this.damageReduction = damageReduction;
            this.armorCost = armorCost;
            isBoughtArmor = bought;
        }
    }
}
