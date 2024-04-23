using Final_Project.Monsters.Forest;
using Final_Project.Monsters;
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
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int MaxMana { get; set; }
        public int Gold { get; set; }
        public int Exp { get; set; }
        public int LevelUpCost { get; set; }
        public int Level { get; set; }
        public string CurrentWeaponName { get; set; }
        public int CurrentWeaponDamage { get; set; }
        public string CurrentArmorName { get; set; }
        public int CurrentArmorProtection { get; set; }

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

        public List<string> MonsterDropNames { get; set; }
        public List<int> MonsterDropAmount { get; set; }
        public List<int> MonsterDropCost { get; set; }
        public List<string> WeaponsList { get; set; }
        public List<int> WeaponDamage { get; set; }
        public List<string> ArmorList { get; set; }
        public List<int> ArmorProtection { get; set; }

        public SaveData(string name, int maxHP, int maxMana, int gold, int exp, int levelUpCost, int level,
                string currentWeaponName, int currentWeaponDamage, string currentArmorName,
                int currentArmorProtection, List<string> monsterDropNames, List<int> monsterDropAmount,
                List<int> monsterDropCost, List<string> weaponsList, List<int> weaponDamage,
                List<string> armorList, List<int> armorProtection,
                bool goblin, bool wolf, bool slime, bool ogre, bool kobold,
                bool mimic, bool skeleton, bool spider, bool troll, bool gnoll,
                bool manticore, bool mummy, bool purpleworm, bool roc, bool harpy,
                bool hydra, bool kraken, bool merfolk, bool pirate, bool sahuagin, bool tiamat)
        {
            Name = name;
            MaxHP = maxHP;
            MaxMana = maxMana;
            Gold = gold;
            Exp = exp;
            LevelUpCost = levelUpCost;
            Level = level;
            CurrentWeaponName = currentWeaponName;
            CurrentWeaponDamage = currentWeaponDamage;
            CurrentArmorName = currentArmorName;
            CurrentArmorProtection = currentArmorProtection;
            MonsterDropNames = monsterDropNames;
            MonsterDropAmount = monsterDropAmount;
            MonsterDropCost = monsterDropCost;
            WeaponsList = weaponsList;
            WeaponDamage = weaponDamage;
            ArmorList = armorList;
            ArmorProtection = armorProtection;

            this.goblin = goblin;
            this.wolf = wolf;
            this.slime = slime;
            this.ogre = ogre;
            this.kobold = kobold;
            this.mimic = mimic;
            this.skeleton = skeleton;
            this.spider = spider;
            this.troll = troll;
            this.gnoll = gnoll;
            this.manticore = manticore;
            this.mummy = mummy;
            this.purpleworm = purpleworm;
            this.roc = roc;
            this.harpy = harpy;
            this.hydra = hydra;
            this.kraken = kraken;
            this.merfolk = merfolk;
            this.pirate = pirate;
            this.sahuagin = sahuagin;
            this.tiamat = tiamat;
        }
    }
}




/*public string name;

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
}*/
