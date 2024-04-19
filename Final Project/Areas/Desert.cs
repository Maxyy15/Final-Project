using Final_Project.Important_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Areas
{
    internal class Desert : Area
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
                    Fighting.Fight();
                    break;
                case "escape":
                    Console.WriteLine("The chest opens and you get a key.");
                    Game.Transition<Menu>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
