using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Monsters
{
    internal class Tiamat : Monster
    {
        public Tiamat(string name, int hp, int damage)
        {
            this.monsterName = name;
            this.monsterHP = hp;
            this.monsterDamage = damage;
        }
    }
}
