using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Monsters
{
    internal class Monster
    {
        public string monsterName;

        public int monsterHP;
        public int maxMonsterHP;
        public int healAmount;
        public bool doesHeal;
        public bool hasBeenKilled = false;

        public int monsterDamage;

        public int monsterExp;
        public int monsterDrop;

        public string monsterDropName;
        public static int monsterDropSell = 100;
        public int monsterGold;

        public bool playerStatusEffect;

        public bool doesStatusEffect;
        public string statusEffectName;
    }
}
