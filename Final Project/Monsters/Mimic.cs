﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Monsters
{
    internal class Mimic : Monster
    {
        public int monsterGold;
        public Mimic(string name, int hp, int damage, int exp, int gold)
        {
            this.monsterName = name;
            this.monsterHP = hp;
            this.monsterDamage = damage;
            this.monsterExp = exp;
            this.monsterGold = gold;
        }
    }
}
