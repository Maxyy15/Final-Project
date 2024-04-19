﻿using Final_Project;
using Final_Project.Player_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Areas
{
    internal class Home : Area
    {

        internal override string CreateDescription() =>
@"This is your home that you inherited from your late grandfather, an adventurer just like you!
He left this to you so you could have a place to stay while you finish his quest to save the world from Tiamat's wrath!

You can 'Rest' to regain your health and mana!
Check your 'Inventory' and see how much of everything you have!
Swap your 'Equipment' in case you want to try out different weapons!
Or 'Leave' and start your day adventuring!
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "rest":
                    Console.WriteLine("You decided to rest!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n HP ");

                    Console.ResetColor();
                    Console.Write("and");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Mana ");

                    Console.ResetColor();
                    Console.WriteLine("are fully restored!");

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
                    Game.Transition<Menu>();
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
