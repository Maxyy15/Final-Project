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
        public static Weapons bronzeSword = new Weapons("Bronze Sword", 10, 50, false);
        public static Weapons ironSword = new Weapons("Iron Sword", 15, 75, false);
        public static Weapons silverSword = new Weapons("Silver Sword", 35, 75, false);
        public static Weapons platinumSword = new Weapons("Platinum Sword", 55, 125, false);
        public static Weapons titaniumSword = new Weapons("Titanium Sword", 100, 200, false);
        public static Weapons amalgamSword = new Weapons("Amalgam's Sword", 175, 375, false);
        public static Weapons gemSword = new Weapons("The Gem Dragon's Bane", 500, 1000, false);

        public static Weapons godSword = new Weapons("God's Wrath", 10000, 5000, false);


        public static Armor bronzeArmor = new Armor("Bronze Armor", 5, 75, false);
        public static Armor ironArmor = new Armor("Iron Armor", 15, 150, false);
        public static Armor silverArmor = new Armor("Silver Sword", 35, 250, false);
        public static Armor platinumArmor = new Armor("Platinum Armor", 55, 350, false);
        public static Armor titaniumArmor = new Armor("Titanium Armor", 100, 550, false);
        public static Armor amalgamArmor = new Armor("Amalgam's Armor", 180, 1150, false);
        public static Armor gemArmor = new Armor("The Gem Dragon's Scales", 400, 2000, false);

        public static Armor godArmor = new Armor("God's Protection", 10000, 50000, false);

        public static void ShopWeapons()
        {
            string option;
            
        shop:
            Console.WriteLine("You have ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(Program.adventurer.Gold + " gold!");
            Console.ResetColor();
            Console.WriteLine("You see several different weapons to chose from!\n");
            Console.WriteLine($"Type the name to buy the weapon!\n" +
                $"\n'Bronze Sword', it costs {bronzeSword.weaponCost} gold, and does {bronzeSword.weaponDamage} damage!" +
                $"\n'Iron Sword', it costs {ironSword.weaponCost} gold, and does {ironSword.weaponDamage} damage!" +
                $"\n'Platinum Sword', it costs {platinumSword.weaponCost} gold, and does {platinumSword.weaponDamage} damage!" +
                $"\n'Titanium Sword', it costs {titaniumSword.weaponCost} gold, and does {titaniumSword.weaponDamage} damage!" +
                $"\n'Amalgam's Sword', it costs {amalgamSword.weaponCost} gold, and does {amalgamSword.weaponDamage} damage!" +
                $"\n'The Gem Dragon's Bane', it costs {gemSword.weaponCost} gold, and does {gemSword.weaponDamage} damage!" +
                $"\n\nDo you wish to 'Leave' instead?");

            option = Console.ReadLine().ToLower();

            switch (option)
            {
                case "bronze sword":
                    if (Program.adventurer.Gold < bronzeSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.");
                        break;
                    }
                    else if (bronzeSword.isBoughtWeapon == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You already bought this weapon!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= bronzeSword.weaponCost;
                        Console.WriteLine("You bought the Bronze sword!");
                        Program.adventurer.currentWeaponDamage = bronzeSword.weaponDamage;
                        Program.adventurer.currentWeaponName = bronzeSword.weaponName;
                        Inventory.WeaponsList.Insert(1, bronzeSword.weaponName);
                        Inventory.WeaponDamage.Insert(1, (bronzeSword.weaponDamage));
                        bronzeSword.isBoughtWeapon = true;

                    }
                    break;

                case "iron sword":
                    if (Program.adventurer.Gold < ironSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.");
                        break;
                    }
                    else if (ironSword.isBoughtWeapon == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You already bought this weapon!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= ironSword.weaponCost;
                        Console.WriteLine("You bought the Iron sword!");
                        Program.adventurer.currentWeaponDamage = ironSword.weaponDamage;
                        Program.adventurer.currentWeaponName = ironSword.weaponName;
                        Inventory.WeaponsList.Insert(2, ironSword.weaponName);
                        Inventory.WeaponDamage.Insert(2, ironSword.weaponDamage);
                        ironSword.isBoughtWeapon = true;
                    }
                    break;

                case "platinum sword":
                    if (Program.adventurer.Gold < platinumSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.");
                        break;
                    }
                    else if (platinumSword.isBoughtWeapon == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You already bought this weapon!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= platinumSword.weaponCost;
                        Console.WriteLine("You bought the Platinum sword!");
                        Program.adventurer.currentWeaponDamage = platinumSword.weaponDamage;
                        Program.adventurer.currentWeaponName = platinumSword.weaponName;
                        Inventory.WeaponsList.Insert(3,platinumSword.weaponName);
                        Inventory.WeaponDamage.Insert(3, platinumSword.weaponDamage);
                        platinumSword.isBoughtWeapon = true;
                    }
                    break;

                case "titanium sword":
                    if (Program.adventurer.Gold < titaniumSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.\n");
                        break;
                    }
                    else if (titaniumSword.isBoughtWeapon == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You already bought this weapon!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= titaniumSword.weaponCost;
                        Console.WriteLine("You bought the Titanium sword!");
                        Program.adventurer.currentWeaponDamage = titaniumSword.weaponDamage;
                        Program.adventurer.currentWeaponName = titaniumSword.weaponName;
                        Inventory.WeaponsList.Insert(4, titaniumSword.weaponName);
                        Inventory.WeaponDamage.Insert(4, titaniumSword.weaponDamage);
                        titaniumSword.isBoughtWeapon = true;
                    }
                    break;

                case "amalgam's sword":
                    if (Program.adventurer.Gold < amalgamSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.\n");
                        break;
                    }
                    else if (amalgamSword.isBoughtWeapon == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You already bought this weapon!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= amalgamSword.weaponCost;
                        Console.WriteLine("You bought the Amalgam's sword!\n");
                        Program.adventurer.currentWeaponDamage = amalgamSword.weaponDamage;
                        Program.adventurer.currentWeaponName = amalgamSword.weaponName;
                        Inventory.WeaponsList.Insert(5, amalgamSword.weaponName);
                        Inventory.WeaponDamage.Insert(5, amalgamSword.weaponDamage);
                        amalgamSword.isBoughtWeapon = true;
                    }
                    break;

                case "the gem dragon's bane":
                    if (Program.adventurer.Gold < gemSword.weaponCost)
                    {
                        Console.Clear();
                        Console.WriteLine("Sorry but you don't have enough gold to buy the sword.\n");
                        break;
                    }
                    else if (gemSword.isBoughtWeapon == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You already bought this weapon!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Program.adventurer.Gold -= gemSword.weaponCost;
                        Console.WriteLine("You bought The Gem Dragon's Bane!\n");
                        Program.adventurer.currentWeaponDamage = gemSword.weaponDamage;
                        Program.adventurer.currentWeaponName = gemSword.weaponName;
                        Inventory.WeaponsList.Insert(6, gemSword.weaponName);
                        Inventory.WeaponDamage.Insert(6, gemSword.weaponDamage);
                        gemSword.isBoughtWeapon = true;
                    }
                    break;

                case "god's wrath":
                    {
                        Program.adventurer.currentWeaponDamage = godSword.weaponDamage;
                        Program.adventurer.currentWeaponName = godSword.weaponName;
                        Console.Clear();
                    }
                    break;

                case "leave":
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

        shop:
            Console.WriteLine("You have ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(Program.adventurer.Gold + " gold!");
            Console.ResetColor();
            Console.WriteLine("You see several different armors to chose from!\n");
            Console.WriteLine($"Type in the name of the Armor to buy it!\n" +
                $"\n'Bronze Armor', it costs {bronzeArmor.armorCost} gold and protects you from {bronzeArmor.damageReduction} damage!" +
                $"\n'Iron Armor', it costs {ironArmor.armorCost} gold and protects you from {ironArmor.damageReduction} damage!" +
                $"\n'Platinum Armor', it costs {platinumArmor.armorCost} gold and protects you from {platinumArmor.damageReduction} damage!" +
                $"\n'Titanium Armor', it costs {titaniumArmor.armorCost} gold and protects you from {titaniumArmor.damageReduction} damage!" +
                $"\n'Amalgam's Armor', it costs {amalgamArmor.armorCost} gold and protects you from {amalgamArmor.damageReduction} damage!" +
                $"\n'The Gem Dragon's Scales', it costs {gemArmor.armorCost} gold and protects you from {gemArmor.damageReduction} damage!" +
                $"\n\nDo you wish to 'Leave' instead?");

            option = Console.ReadLine().ToLower();
            switch (option)
            {
                case "bronze armor":
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

                        Inventory.ArmorList.Insert(1, Program.adventurer.currentArmorName);
                        Inventory.ArmorProtection.Insert(1, Program.adventurer.currentArmorProtection);
                        bronzeArmor.isBoughtArmor = true;
                    }
                    break;

                case "iron armor":
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

                        Inventory.ArmorList.Insert(2, Program.adventurer.currentArmorName);
                        Inventory.ArmorProtection.Insert(2, Program.adventurer.currentArmorProtection);
                        ironArmor.isBoughtArmor = true;

                    }
                    break;

                case "platinum armor":
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

                        Inventory.ArmorList.Insert(3, Program.adventurer.currentArmorName);
                        Inventory.ArmorProtection.Insert(3, Program.adventurer.currentArmorProtection);
                        platinumArmor.isBoughtArmor = true;

                    }
                    break;

                case "titanium armor":
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

                        Inventory.ArmorList.Insert(4, Program.adventurer.currentArmorName);
                        Inventory.ArmorProtection.Insert(4, Program.adventurer.currentArmorProtection);
                        titaniumArmor.isBoughtArmor = true;

                    }
                    break;

                case "amalgam's armor":
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

                        Inventory.ArmorList.Insert(5, Program.adventurer.currentArmorName);
                        Inventory.ArmorProtection.Insert(5, Program.adventurer.currentArmorProtection);
                        amalgamArmor.isBoughtArmor = true;

                    }
                    break;

                case "the gem dragon's scales":
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

                        Inventory.ArmorList.Insert(6, Program.adventurer.currentArmorName);
                        Inventory.ArmorProtection.Insert(6, Program.adventurer.currentArmorProtection);
                        gemArmor.isBoughtArmor = true;
                    }
                    break;

                case "god's protection":
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
