using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Player_Stuff
{
    internal class Magic
    {
        public string magicName;
        public string magicType;
        public string magicStatus;
        public int magicDamage;
        public int magicCost;
        public int magicDuration = 0;
        public int hitChance;

        public Magic(string magicName, string magicType, int magicDamage, int magicCost)
        {
            this.magicName = magicName;
            this.magicType = magicType;
            this.magicDamage = magicDamage;
            this.magicCost = magicCost;
        }
    }
}
