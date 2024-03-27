using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Player
    {
        public string name;
        public int HP = 100;
        public int Mana = 50;
        public int Gold = 500;
        public int Exp = 0;
        public int Level = 1;

        public string currentWeaponName;
        public int currentWeaponDamage = 0;

        public string currentArmorName;
        public int currentArmorProtection = 0;

        public string currentMagicSpell;
        public string currentMagicType;
        public string currentMagicStatus;
        public int currentMagicDamage;
        public int currentMagicCost;
    }
}
