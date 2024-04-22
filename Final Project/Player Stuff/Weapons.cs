using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Player_Stuff
{
    internal class Weapons
    {
        public string weaponName;
        public int weaponDamage;
        public int weaponCost;
        public bool isBoughtWeapon;

        public Weapons(string weaponName, int weaponDamage, int weaponCost, bool bought)
        {
            this.weaponName = weaponName;
            this.weaponDamage = weaponDamage;
            this.weaponCost = weaponCost;
            isBoughtWeapon = bought;
        }

        
    }
}
