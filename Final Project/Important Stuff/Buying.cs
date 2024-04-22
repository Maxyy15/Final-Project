using Final_Project.Player_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Important_Stuff
{
    internal class Buying
    {
        public static void ShopWeapons()
        {
            string option;
            Weapons bronzeSword = new Weapons("Bronze Sword", 10, 5);
            Weapons ironSword = new Weapons("Iron Sword", 25, 15);
            Weapons platinumSword = new Weapons("Platinum Sword", 30, 20);
            Weapons titaniumSword = new Weapons("Titanium Sword", 50, 35);
            Weapons amalgamSword = new Weapons("Amalgam's Sword", 100, 70);
            Weapons gemSword = new Weapons("The Gem Dragon's Bane", 500, 355);
            Weapons godSword = new Weapons("God's Wrath", 10000, 5000);

        shop:
            Console.WriteLine("You see several different weapons to chose from!\n");
            Console.WriteLine($"Type the name to buy the weapon!\n" +
                $"\n'Bronze Sword', it costs {bronzeSword.weaponCost} gold, and does {bronzeSword.weaponDamage} damage!" +
                $"\n'Iron Sword', it costs {ironSword.weaponCost} gold, and does {ironSword.weaponDamage} damage!" +
                $"\n'Platinum Sword', it costs {platinumSword.weaponCost} gold, and does {platinumSword.weaponDamage} damage!" +
                $"\n'Titanium Sword', it costs {titaniumSword.weaponCost} gold, and does {titaniumSword.weaponDamage} damage!" +
                $"\n'Amalgam's Sword', it costs {amalgamSword.weaponCost} gold, and does {amalgamSword.weaponDamage} damage!" +
                $"\n'The Gem Dragon's Bane', it costs {gemSword.weaponCost} gold, and does {gemSword.weaponDamage} damage!" +
                $"\n\nDo you wish to 'Leave' instead?");

            option = Console.ReadLine();

            switch (option)
            {
                case "Bronze Sword":
                    if (Program.adventurer.Gold < bronzeSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= bronzeSword.weaponCost;
                        Console.WriteLine("You bought the Bronze sword!");
                        Program.adventurer.currentWeaponDamage = bronzeSword.weaponDamage;
                        Program.adventurer.currentWeaponName = bronzeSword.weaponName;
                    }
                    break;

                case "Iron Sword":
                    if (Program.adventurer.Gold < ironSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= ironSword.weaponCost;
                        Console.WriteLine("You bought the Iron sword!");
                        Program.adventurer.currentWeaponDamage = ironSword.weaponDamage;
                        Program.adventurer.currentWeaponName = ironSword.weaponName;
                    }
                    break;

                case "Platinum Sword":
                    if (Program.adventurer.Gold < platinumSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= platinumSword.weaponCost;
                        Console.WriteLine("You bought the Platinum sword!");
                        Program.adventurer.currentWeaponDamage = platinumSword.weaponDamage;
                        Program.adventurer.currentWeaponName = platinumSword.weaponName;
                    }
                    break;

                case "Titanium Sword":
                    if (Program.adventurer.Gold < titaniumSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.\n");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= titaniumSword.weaponCost;
                        Console.WriteLine("You bought the Titanium sword!");
                        Program.adventurer.currentWeaponDamage = titaniumSword.weaponDamage;
                        Program.adventurer.currentWeaponName = titaniumSword.weaponName;
                    }
                    break;

                case "Amalgam's Sword":
                    if (Program.adventurer.Gold < amalgamSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.\n");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= amalgamSword.weaponCost;
                        Console.WriteLine("You bought the Amalgam's sword!\n");
                        Program.adventurer.currentWeaponDamage = amalgamSword.weaponDamage;
                        Program.adventurer.currentWeaponName = amalgamSword.weaponName;
                    }
                    break;

                case "The Gem Dragon's Bane":
                    if (Program.adventurer.Gold < gemSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.\n");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= gemSword.weaponCost;
                        Console.WriteLine("You bought The Gem Dragon's Bane!\n");
                        Program.adventurer.currentWeaponDamage = gemSword.weaponDamage;
                        Program.adventurer.currentWeaponName = gemSword.weaponName;
                    }
                    break;

                case "God's Wrath":
                    {
                        Program.adventurer.currentWeaponDamage = godSword.weaponDamage;
                        Program.adventurer.currentWeaponName = godSword.weaponName;
                        Console.Clear();
                    }
                    break;

                case "Leave":
                    {
                        Console.Clear();
                        Console.WriteLine("You decided to leave!");
                    }
                    break;

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter valid option!");
                        goto shop;
                    }
            }
        }

        public static void ShopArmor()
        {
            string option;
            Armor bronzeArmor = new Armor("Bronze Armor", 5, 15);
            Armor ironArmor = new Armor("Iron Armor", 10, 30);
            Armor platinumArmor = new Armor("Platinum Armor", 20, 60);
            Armor titaniumArmor = new Armor("Titanium Armor", 40, 100);
            Armor amalgamArmor = new Armor("Amalgam's Armor", 100, 400);
            Armor gemArmor = new Armor("The Gem Dragon's Scales", 400, 1000);
            Armor godArmor = new Armor("God's Protection", 10000, 50000);

        shop:
            Console.WriteLine("You see several different armors to chose from!\n");
            Console.WriteLine($"Type in the name of the Armor to buy it!\n" +
                $"\n'Bronze Armor', it costs {bronzeArmor.armorCost} gold and protects you from {bronzeArmor.damageReduction} damage!" +
                $"\n'Iron Armor', it costs {ironArmor.armorCost} gold and protects you from {ironArmor.damageReduction} damage!" +
                $"\n'Platinum Armor', it costs {platinumArmor.armorCost} gold and protects you from {platinumArmor.damageReduction} damage!" +
                $"\n'Titanium Armor', it costs {titaniumArmor.armorCost} gold and protects you from {titaniumArmor.damageReduction} damage!" +
                $"\n'Amalgam's Armor', it costs {amalgamArmor.armorCost} gold and protects you from {amalgamArmor.damageReduction} damage!" +
                $"\n'The Gem Dragon's Scales', it costs {gemArmor.armorCost} gold and protects you from {gemArmor.damageReduction} damage!" +
                $"\n\nDo you wish to 'Leave' instead?");

            option = Console.ReadLine();
            switch (option)
            {
                case "Bronze Sword":
                    if (Program.adventurer.Gold < bronzeArmor.armorCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the armor.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= bronzeArmor.armorCost;
                        Console.WriteLine("You bought the Bronze armor!");
                        Program.adventurer.currentArmorProtection = bronzeArmor.damageReduction;
                        Program.adventurer.currentArmorName = bronzeArmor.armorName;
                    }
                    break;

                case "Iron Armor":
                    if (Program.adventurer.Gold < ironArmor.armorCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the armor.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= ironArmor.armorCost;
                        Console.WriteLine("You bought the Iron armor!");
                        Program.adventurer.currentArmorProtection = ironArmor.damageReduction;
                        Program.adventurer.currentArmorName = ironArmor.armorName;
                    }
                    break;

                case "Platinum Armor":
                    if (Program.adventurer.Gold < platinumArmor.armorCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the armor.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= platinumArmor.armorCost;
                        Console.WriteLine("You bought the Platinum armor!");
                        Program.adventurer.currentArmorProtection = platinumArmor.damageReduction;
                        Program.adventurer.currentArmorName = platinumArmor.armorName;
                    }
                    break;

                case "Titanium Armor":
                    if (Program.adventurer.Gold < titaniumArmor.armorCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the armor.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= titaniumArmor.armorCost;
                        Console.WriteLine("You bought the Titanium armor!");
                        Program.adventurer.currentArmorProtection = titaniumArmor.damageReduction;
                        Program.adventurer.currentArmorName = titaniumArmor.armorName;
                    }
                    break;

                case "Amalgam's Armor":
                    if (Program.adventurer.Gold < amalgamArmor.armorCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the armor.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= amalgamArmor.armorCost;
                        Console.WriteLine("You bought Amalgam's armor!");
                        Program.adventurer.currentArmorProtection = amalgamArmor.damageReduction;
                        Program.adventurer.currentArmorName = amalgamArmor.armorName;
                    }
                    break;

                case "The Gem Dragon's Scales":
                    if (Program.adventurer.Gold < gemArmor.armorCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the armor.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= gemArmor.armorCost;
                        Console.WriteLine("You bought The Gem Dragon's Scales!");
                        Program.adventurer.currentArmorProtection = gemArmor.damageReduction;
                        Program.adventurer.currentArmorName = gemArmor.armorName;
                    }
                    break;

                case "God's Protection":
                    {
                        Program.adventurer.currentArmorName = godArmor.armorName;
                        Program.adventurer.currentArmorProtection = godArmor.damageReduction;
                        Console.Clear();
                    }
                    break;

                case "Leave":
                    {
                        Console.Clear();
                        Console.WriteLine("You decided to leave!\n");
                    }
                    break;

                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter valid option!\n");
                        goto shop;
                    }
            }


            //if (option == "God's Protection")
            //{
            //    adventurer.currentArmorName = godArmor.armorName;
            //    adventurer.currentArmorProtection = godArmor.damageReduction;
            //}
            //adventurer.Gold -= godArmor.armorCost;
        }
    }
}
