using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Monsters
{
    internal class Pirate : Monster
    {
        public Pirate (string name, int hp, int damage, int exp, int gold)
        {
            this.monsterName = name;
            this.monsterHP = hp;
            this.monsterDamage = damage;
            this.monsterExp = exp;
            this.monsterGold = gold;
        }
    }
}
