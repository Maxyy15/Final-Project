﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Monsters
{
    internal class Slime : Monster
    {
        public int maxMonsterHP;
        public int healAmount;
        public Slime(string name, int hp, int damage, int exp, int drop)
        {
            this.monsterName = name;
            this.monsterHP = hp;
            this.monsterDamage = damage;
            this.monsterExp = exp;
            this.monsterDrop = drop;
        }
        
    }
}
