﻿using Final_Project.Important_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Areas
{
    internal class Forest : Area
    {

        internal override string CreateDescription() =>
@"You decided to go towards the forest!
You see a sign warning you about the increase in monsters!
Specifically Goblins, Wolves and Slimes!

Please press any key to continue!
";

        internal override void ReceiveChoice(string choice)
        {
            choice = "continue";
            switch (choice)
            {
                case "continue":
                    //Console.WriteLine("You decided to go deep into the forest!");
                    //Console.WriteLine("Please press any key to continue!");
                    Fighting.Fight();
                    break;
                case "leave":
                    Console.WriteLine("You decide to go back to safety!");
                    Game.Transition<Menu>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
