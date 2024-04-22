using Final_Project.Important_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Areas
{
    internal class Cave : Area
    {

        internal override string CreateDescription() =>
@"You decided to go towards the cave!
The sounds of growls, the clacking of bones and the scuttling of bugs fill your ears as you approach!

You can 'Continue' to search for enemies to fight or 'Leave' to fight another day!
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "continue":
                    Console.WriteLine("You decided to look around!");
                    Fighting.Fight();
                    break;
                case "leave":
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
