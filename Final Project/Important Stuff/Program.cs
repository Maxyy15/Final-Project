using Final_Project.Areas;
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
using System.Runtime.Serialization.Formatters.Binary;


namespace Final_Project
{
    internal class Program
    {
        public static Player adventurer = new Player();
        public static int levelUpCost = 30, maxHP = 100, maxMana = 50, playerStatusCount, monstersStatusCount;
        public static string currentArea;
        public static bool cast = false;
        public static bool die = false;

        static void Main(string[] args)
        {
            if(File.Exists(Home.SaveFile))
            {
                Console.WriteLine("Do you want to load your previous data?\n'Yes' or 'No'?\nKeep in mind if you say no, your save data will be deleted.");
                string ans = Console.ReadLine().ToLower();
                if(ans == "yes")
                {
                    LoadData.Load();
                    goto start;
                }
                if(ans == "no") 
                {
                    LoadData.CloseFileStream();

                    File.Delete(Home.SaveFile);
                    goto okiedokie;
                }
            }

        okiedokie:
            Console.Clear();
            Initializing.Initialize();

            Weapons woodenSword = new Weapons("Wooden Sword", 5, 0, true);
            Inventory.WeaponsList.Insert(0, woodenSword.weaponName);
            Inventory.WeaponDamage.Insert(0, woodenSword.weaponDamage);
            Armor uselessArmor = new Armor("Useless Armor", 1, 0, true);
            Inventory.ArmorList.Insert(0, uselessArmor.armorName);
            Inventory.ArmorProtection.Insert(0, uselessArmor.damageReduction);

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
        start:

            var game = new Game();
            Console.Clear();
            game.Add(new Home());
            game.Add(new Menu());
            game.Add(new Shop());
            game.Add(new AreaList());

            game.Add(new Forest());
            game.Add(new Cave());
            game.Add(new Desert());
            game.Add(new Sea());
            game.Add(new TiamatsLair());

            while (!game.IsGameOver())
            {
                Console.WriteLine("--");
                Console.WriteLine(game.CurrentAreaDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }

            if (die == true)
            {
                Console.WriteLine("You failed to save the world from Tiamat\nAs the light begins to leave your eyes, you could only wish that you were just a little stronger.\n" +
                    "Maybe in your next life you could save everyone.\n");
            }
            else
            {
                Console.WriteLine("You saved the world from Tiamat!\nTheir evil shall no longer corrupt the inhabitants of this world!\nAlthough many may not know what you" +
                    " have gone through to get the this point, that doesn't matter\nYou won.");
            }
            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
