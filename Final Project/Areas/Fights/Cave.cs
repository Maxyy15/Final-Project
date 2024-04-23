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
The sounds of growls, the clacking of bones and the scuttling of bugs fill your ears as you approach.
You feel a deep evil aura emanating from within the cave.

You can 'Continue' to go deeper!
You can 'Leave' and fight another day!
Or you can 'Learn' about the ememies you've fought so far!
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
                case "learn":
                    Learning.Learn();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
