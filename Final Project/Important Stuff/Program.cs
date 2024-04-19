using Final_Project.Areas;
using Final_Project.Player_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Program
    {
        public static Player adventurer = new Player();
        public static int maxHP = 100, maxMana = 50;
        public static string currentArea;

        static void Main(string[] args)
        {
            Weapons woodenSword = new Weapons("Wooden Sword", 5, 0);
            var game = new Game();
            Console.WriteLine("Hello Adventurer!\nWelcome to the Text Based Adventure Game!\nPlease enter your name below!");
            adventurer.name = Console.ReadLine();
            Console.Clear();

            adventurer.Introduction();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You recieved a wooden sword in the mail from the shop!\nPress any key to continue!");
            adventurer.currentWeaponDamage = woodenSword.weaponDamage;
            adventurer.currentWeaponName = woodenSword.weaponName;
            Console.ReadKey();
            Console.Clear();

            game.Add(new Home());
            game.Add(new Menu());
            game.Add(new Shop());
            game.Add(new AreaList());
            game.Add(new Forest());
            
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
