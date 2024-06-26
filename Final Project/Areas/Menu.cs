﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Areas
{
    internal class Menu : Area
    {
        internal override string CreateDescription() =>
@"You have several different options you can choose from here!
You can 'Explore' and go see different areas to fight monsters in!
You can go to the 'Shop' and buy new weapons and armor!
You can go 'Home' to rest up and apply your skill points!
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "explore":
                    Console.WriteLine("You decided to go explore!");
                    Game.Transition<AreaList>();
                    break;
                case "home":
                    Console.WriteLine("You decided to go home!");
                    Game.Transition<Home>();
                    break;
                case "shop":
                    Console.WriteLine("You decided to go to the shop!");
                    Game.Transition<Shop>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
