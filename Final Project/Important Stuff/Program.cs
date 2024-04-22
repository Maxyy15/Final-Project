﻿using Final_Project.Areas;
using Final_Project.Important_Stuff;
using Final_Project.Player_Stuff;
using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Final_Project
{
    internal class Program
    {
        public static Player adventurer = new Player();
        public static int levelUpCost = 30, maxHP = 100, maxMana = 50, playerStatusCount, monstersStatusCount;
        public static string currentArea;
        public static bool cast = false;

        static void Main(string[] args)
        {

            Initializing.Initialize();

            Weapons woodenSword = new Weapons("Wooden Sword", 5, 0, true);
            Inventory.WeaponsList.Insert(0, woodenSword.weaponName);
            Inventory.WeaponDamage.Insert(0, woodenSword.weaponDamage);
            Armor uselessArmor = new Armor("Useless Armor", 1, 0, true);
            Inventory.ArmorList.Insert(0, uselessArmor.armorName);
            Inventory.ArmorProtection.Insert(0, uselessArmor.damageReduction);

            var game = new Game();
            Console.WriteLine("Hello Adventurer!\nWelcome to the Text Based Adventure Game!\nPlease enter your name below!");
            adventurer.name = Console.ReadLine();
            Console.Clear();

            adventurer.Introduction();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You recieved a 'Wooden Sword' and 'Useless Armor' in the mail from the shop!\nPress any key to continue!");
            adventurer.currentWeaponDamage = woodenSword.weaponDamage;
            adventurer.currentWeaponName = woodenSword.weaponName;
            Console.ReadKey();
            Console.Clear();

            game.Add(new Home());
            game.Add(new Menu());
            game.Add(new Shop());

            game.Add(new AreaList());
            game.Add(new Forest());
            game.Add(new Cave());
            game.Add(new Desert());
            game.Add(new Ocean());

            while (!game.IsGameOver())
            {
                Console.WriteLine("--");
                Console.WriteLine(game.CurrentAreaDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }

                Console.WriteLine("END");
                Console.ReadLine();
        }
    }
}
