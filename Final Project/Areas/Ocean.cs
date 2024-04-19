using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Areas
{
    internal class Ocean : Area
    {

        internal override string CreateDescription() =>
@"You decided to go into the forest!
In the forest, Goblins, Slimes and Wolves are abundent!
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "look":
                    Console.WriteLine("You decided to look around!");
                    Game.Transition<Home>();
                    break;
                case "escape":
                    Console.WriteLine("The chest opens and you get a key.");
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
