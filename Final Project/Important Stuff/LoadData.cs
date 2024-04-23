using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Areas;
using System.Runtime.Serialization.Formatters.Binary;
using Final_Project.Player_Stuff;

namespace Final_Project.Important_Stuff
{
    internal class LoadData
    {
        public static void Load()
        {
            SaveData loadedData = DeserializeData();

            Program.adventurer.name = loadedData.name;

            Program.maxHP = loadedData.HP;
            Program.adventurer.HP = loadedData.HP;
            Program.maxMana = loadedData.Mana;
            Program.adventurer.Mana = loadedData.Mana;
            Program.adventurer.Gold = loadedData.Gold;
            Program.adventurer.Exp = loadedData.Exp;
            Program.adventurer.Level = loadedData.Level;

            Program.adventurer.currentWeaponName = loadedData.currentWeaponName;
            Program.adventurer.currentWeaponDamage = loadedData.currentWeaponDamage;
            Program.adventurer.currentArmorName = loadedData.currentArmorName;
            Program.adventurer.currentArmorProtection = loadedData.currentArmorProtection;

            Inventory.monsterDropNames = loadedData.monsterDropNameSave;
            Inventory.monsterDropAmount = loadedData.monsterDropAmountSave;
            Inventory.monsterDropCost = loadedData.monsterDropCostSave;

            Inventory.WeaponsList = loadedData.WeaponsListSave;
            Inventory.WeaponDamage = loadedData.WeaponDamageSave;
            Inventory.ArmorList = loadedData.ArmorListSave;
            Inventory.ArmorProtection = loadedData.ArmorProtectionSave;

            Learning.goblin = loadedData.goblin;
            Learning.wolf = loadedData.wolf;
            Learning.slime = loadedData.slime;
            Learning.ogre = loadedData.ogre;
            Learning.kobold = loadedData.kobold;
            Learning.mimic = loadedData.mimic;
            Learning.skeleton = loadedData.skeleton;
            Learning.spider = loadedData.spider;
            Learning.troll = loadedData.troll;
            Learning.gnoll = loadedData.gnoll;
            Learning.manticore = loadedData.manticore;
            Learning.mummy = loadedData.mummy;
            Learning.purpleworm = loadedData.purpleworm;
            Learning.roc = loadedData.roc;
            Learning.harpy = loadedData.harpy;
            Learning.hydra = loadedData.hydra;
            Learning.kraken = loadedData.kraken;
            Learning.merfolk = loadedData.merfolk;
            Learning.pirate = loadedData.pirate;
            Learning.sahuagin = loadedData.sahuagin;
            Learning.tiamat = loadedData.tiamat;
        }

        public static SaveData DeserializeData()
        {

            if (File.Exists(Home.SaveFile))
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(Home.SaveFile, FileMode.Open))
                {
                    return (SaveData)bf.Deserialize(fs);
                }
            }
            else
            {
                Console.WriteLine("Save file does not exist.");
                return null;
            }

        }
    }
}
