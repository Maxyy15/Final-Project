using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Areas;
using System.Runtime.Serialization.Formatters.Binary;
using Final_Project.Player_Stuff;
using System.IO.Pipes;

namespace Final_Project.Important_Stuff
{
    internal class LoadData
    {
        private static FileStream fileStream;
        public static void Load()
        {
            var loader = new LoadData();
            SaveData loadedData = DeserializeData();

            if (loadedData != null)
            {
                Program.adventurer.name = loadedData.Name;
                Program.maxHP = loadedData.MaxHP;
                Program.adventurer.HP = loadedData.MaxHP;
                Program.maxMana = loadedData.MaxMana;
                Program.adventurer.Mana = loadedData.MaxMana;
                Program.adventurer.Gold = loadedData.Gold;
                Program.adventurer.Exp = loadedData.Exp;
                Program.adventurer.Level = loadedData.Level;
                Program.adventurer.currentWeaponName = loadedData.CurrentWeaponName;
                Program.adventurer.currentWeaponDamage = loadedData.CurrentWeaponDamage;
                Program.adventurer.currentArmorName = loadedData.CurrentArmorName;
                Program.adventurer.currentArmorProtection = loadedData.CurrentArmorProtection;
                Inventory.monsterDropNames = loadedData.MonsterDropNames;
                Inventory.monsterDropAmount = loadedData.MonsterDropAmount;
                Inventory.monsterDropCost = loadedData.MonsterDropCost;
                Inventory.WeaponsList = loadedData.WeaponsList;
                Inventory.WeaponDamage = loadedData.WeaponDamage;
                Inventory.ArmorList = loadedData.ArmorList;
                Inventory.ArmorProtection = loadedData.ArmorProtection;



                
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
            else
            {
                // Handle the case when loadedData is null
                Console.WriteLine("Error: Save data is null.");
            }

            // Close the file stream after deserialization
            CloseFileStream();
        }
    
        public static void CloseFileStream()
        {
            if (fileStream != null)
            {
                fileStream.Close(); // Close the file stream if it's not null
                fileStream.Dispose(); // Dispose of the file stream to release resources
            }
        }
        public static SaveData DeserializeData()
        {

            //if (File.Exists(Home.SaveFile))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    using (FileStream fs = new FileStream(Home.SaveFile, FileMode.Open))
            //    {
            //        return (SaveData)bf.Deserialize(fs);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Save file does not exist.");
            //    return null;
            //}

            Console.WriteLine("Attempting to deserialize data...");
            if (File.Exists(Home.SaveFile))
            {
                Console.WriteLine("Save file found. Deserializing...");
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(Home.SaveFile, FileMode.Open))
                {
                    Console.WriteLine("File stream opened. Deserializing...");
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
