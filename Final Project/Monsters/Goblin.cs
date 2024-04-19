using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Monsters
{
    internal class Goblin : Monster
    {
        public Goblin (string name, int hp, int damage, int exp, int drop)
        {
            this.monsterName = name;
            this.monsterHP = hp;
            this.monsterDamage = damage;
            this.monsterExp = exp;
            this.monsterDrop = drop;
        }
    }
}
