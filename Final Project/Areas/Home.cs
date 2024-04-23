using Final_Project;
using Final_Project.Player_Stuff;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Important_Stuff;
using System.Runtime.Serialization.Formatters.Binary;

namespace Final_Project.Areas
{
    internal class Home : Area
    {
        public static SaveData saveData;
        public const string SaveFile = "Save.txt";


        internal override string CreateDescription() =>
@"This is your home that you inherited from your late grandfather, he was an adventurer just like you!
He left this house to you in his will so you could have a place to rest and store your items while you finish the quest he started.

To Slay Tiamat, Evil God of the Dragons.

You can 'Rest' to regain your health and mana!
Check your 'Inventory' and see how much of everything you have!
Swap your 'Equipment' in case you want to try out different weapons!
You can 'Leave' and start your day adventuring!
Or can 'Sleep' and save your progress!
";

        internal override void ReceiveChoice(string choice)
        {

            switch (choice)
            {

                case "rest":
                    Console.WriteLine("You decided to rest!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nHP ");

                    Console.ResetColor();
                    Console.Write("and");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Mana ");

                    Console.ResetColor();
                    Console.WriteLine("is fully restored!");

                    Program.adventurer.HP = Program.maxHP; 
                    Program.adventurer.Mana = Program.maxMana;

                    break;

                case "inventory":
                    Console.WriteLine("You decided to look through the things you've obtained!");

                    Inventory.PlayerInventory();
                    break;

                case "equipment":
                    Console.WriteLine("You decided to look through the things you've obtained!");

                    Inventory.PlayerEquipment();
                    break;

                case "leave":
                    Console.WriteLine("You decided to go back outside!");

                    Console.Write("You currently have ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(Program.adventurer.Gold + " gold");
                    Console.ResetColor();
                    Console.WriteLine("!");

                    Console.Write("Your current ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("HP ");
                    Console.ResetColor();
                    Console.Write("is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{Program.adventurer.HP}");
                    Console.ResetColor();
                    Console.WriteLine("!");

                    Console.Write("Your current ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Mana ");
                    Console.ResetColor();
                    Console.Write("is ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{Program.adventurer.Mana}");
                    Console.ResetColor();
                    Console.WriteLine("!");

                    Game.Transition<Menu>();
                    break;

                case "sleep":

                    if (!File.Exists(SaveFile))
                    {
                        File.CreateText(SaveFile);
                    }
                    var bf = new BinaryFormatter();

                    SaveData saveData = new SaveData(Program.adventurer.name, Program.maxHP, Program.maxMana, Program.adventurer.Gold,
                        Program.adventurer.Exp, Program.levelUpCost, Program.adventurer.Level, Program.adventurer.currentWeaponName,
                        Program.adventurer.currentWeaponDamage, Program.adventurer.currentArmorName, Program.adventurer.currentArmorProtection);

                    saveData.monsterDropNameSave = Inventory.monsterDropNames;
                    saveData.monsterDropAmountSave = Inventory.monsterDropAmount;
                    saveData.monsterDropCostSave = Inventory.monsterDropCost;

                    saveData.WeaponsListSave = Inventory.WeaponsList;
                    saveData.WeaponDamageSave = Inventory.WeaponDamage;
                    saveData.ArmorListSave = Inventory.ArmorList;
                    saveData.ArmorProtectionSave = Inventory.ArmorProtection;

                    saveData.goblin = Learning.goblin;
                    saveData.wolf = Learning.wolf;
                    saveData.slime = Learning.slime;
                    saveData.ogre = Learning.ogre;
                    saveData.kobold = Learning.kobold;
                    saveData.mimic = Learning.mimic;
                    saveData.skeleton = Learning.skeleton;
                    saveData.spider = Learning.spider;
                    saveData.troll = Learning.troll;
                    saveData.gnoll = Learning.gnoll;
                    saveData.manticore = Learning.manticore;
                    saveData.mummy = Learning.mummy;
                    saveData.purpleworm = Learning.purpleworm;
                    saveData.roc = Learning.roc;
                    saveData.harpy = Learning.harpy;
                    saveData.hydra = Learning.hydra;
                    saveData.kraken = Learning.kraken;
                    saveData.merfolk = Learning.merfolk;
                    saveData.pirate = Learning.pirate;
                    saveData.sahuagin = Learning.sahuagin;
                    saveData.tiamat = Learning.tiamat;

                    SerializeData(saveData);

                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
        public static void SerializeData(SaveData data)
        {
            BinaryFormatter bf = new BinaryFormatter();

            // Serialize the object and lists
            using (FileStream fs = new FileStream(SaveFile, FileMode.Create))
            {
                bf.Serialize(fs, data);
            }
        }
    }
}
