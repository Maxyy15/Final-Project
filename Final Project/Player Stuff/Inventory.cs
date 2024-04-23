using Final_Project.Important_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Player_Stuff
{
    internal class Inventory
    {
        public static List<string> monsterDropNames = new List<string>();
        public static List<int> monsterDropAmount = new List<int>();
        public static List<int> monsterDropCost = new List<int>();

        public static List<string> WeaponsList = new List<string>();
        public static List<int> WeaponDamage = new List<int>();

        public static List<string> ArmorList = new List<string>();
        public static List<int> ArmorProtection = new List<int>();



        public static void PlayerInventory()
        {
            int x = 0;

            foreach (string i in monsterDropNames)
            {
                if (monsterDropAmount[x] != 0)
                {
                    Console.WriteLine("You have " + monsterDropAmount[x] + " " + monsterDropNames[x]);
                }
                x++;
            }
        }

        public static void PlayerEquipment()
        {
        retry1:
            Console.WriteLine("You can swap out your equipment here!\nYour 'Armor' and 'Weapons' are laid out neatly in front of you!");
            int x = 0;
            string choice = Console.ReadLine().ToLower();
            string choice1;

            switch(choice)
            {
                case "armor":
                    Console.Clear();
                    tryagain1:
                    x = 0;
                    
                    foreach (string w in ArmorList)
                    {
                        if (ArmorList[x] == "")
                        {
                        }
                        else
                        {
                            Console.WriteLine($"'{ArmorList[x]}' it protects you from {ArmorProtection[x]} damage!");
                        }
                        x++;
                    }
                    Console.WriteLine("Please select your armor!");

                    choice = Console.ReadLine();

                    if (choice == "")
                    {
                        Console.Clear();
                        Console.WriteLine("Please select a valid armor!");
                        goto tryagain1;
                    }
                    else if (ArmorList.Any(armor => armor == choice))
                    {
                        Program.adventurer.currentArmorName = choice;

                        int i = ArmorList.IndexOf(choice);

                        Program.adventurer.currentArmorProtection = ArmorProtection[i];
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please select a valid armor!");
                        goto tryagain1;
                    }
                    Console.Clear();

                    Console.WriteLine($"You selected " + Program.adventurer.currentArmorName + "!");
                    break;

                case "weapons":
                    Console.Clear();
                    tryagain2:
                    x = 0;
                    
                    foreach (string w in WeaponsList)
                    {
                        if (WeaponsList[x] == "")
                        {
                        }
                        else
                        {
                            Console.WriteLine($"'{WeaponsList[x]}' it does {WeaponDamage[x]} damage!");
                        }
                        x++;
                    }

                    Console.WriteLine("Please select your weapon!");
                    choice1 = Console.ReadLine();
                    
                    if(choice1 == "")
                    {
                        Console.Clear();
                        Console.WriteLine("Please select a valid weapon!");
                        goto tryagain2;
                    }
                    else if(WeaponsList.Any(weapon => choice == weapon))
                    {
                        Program.adventurer.currentWeaponName = choice;

                        int i = WeaponsList.IndexOf(choice);

                        Program.adventurer.currentWeaponDamage = WeaponDamage[i];
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please select a valid weapon!");
                        goto tryagain2;
                    }
                    Console.Clear();

                    Console.WriteLine($"You selected " + Program.adventurer.currentWeaponName + "!");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please enter a valid option!");
                    goto retry1;
            }
        }
    }
}
