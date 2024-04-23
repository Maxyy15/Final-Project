using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Important_Stuff
{
    [Serializable]
    internal class SaveData
    {
        public string name;

        public int HP;
        public int Mana;
        public int Gold;
        public int Exp;
        public int LevelUpCost;
        public int Level;

        public string currentWeaponName;
        public int currentWeaponDamage;

        public string currentArmorName;
        public int currentArmorProtection;

        public List<string> monsterDropNameSave;
        public List<int> monsterDropAmountSave;
        public List<int> monsterDropCostSave;

        public List<string> WeaponsListSave;
        public List<int> WeaponDamageSave;

        public List<string> ArmorListSave;
        public List<int> ArmorProtectionSave;

        public bool goblin;
        public bool wolf;
        public bool slime;
        public bool ogre;
        public bool kobold;
        public bool mimic;
        public bool skeleton;
        public bool spider;
        public bool troll;
        public bool gnoll;
        public bool manticore;
        public bool mummy;
        public bool purpleworm;
        public bool roc;
        public bool harpy;
        public bool hydra;
        public bool kraken;
        public bool merfolk;
        public bool pirate;
        public bool sahuagin;
        public bool tiamat;

        public SaveData(string name, int HP, int Mana, int Gold, int Exp, int LevelUpCost, int Level, string weapon, int weaponDamage, string armor, int armorProt)
        {
            this.name = name;
            this.HP = HP;
            this.Mana = Mana;
            this.Gold = Gold;
            this.Exp = Exp;
            this.LevelUpCost = LevelUpCost;
            this.Level = Level;
            currentWeaponName = weapon;
            currentWeaponDamage = weaponDamage;
            currentArmorName = armor;
            currentArmorProtection = armorProt;

            monsterDropNameSave = new List<string>();
            monsterDropAmountSave = new List<int>();
            monsterDropCostSave = new List<int>();

            WeaponsListSave = new List<string>();
            WeaponDamageSave = new List<int>();
            ArmorListSave = new List<string>();
            ArmorProtectionSave = new List<int>();

            goblin = false;
            wolf = false;
            slime = false;
            ogre = false;
            kobold = false;
            mimic = false;
            skeleton = false;
            spider = false;
            troll = false;
            gnoll = false;
            manticore = false;
            mummy = false;
            purpleworm = false;
            roc = false;
            harpy = false;
            hydra = false;
            kraken = false;
            merfolk = false;
            pirate = false;
            sahuagin = false;
            tiamat = false;
        }
    }
}
