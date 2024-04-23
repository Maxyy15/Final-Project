using Final_Project.Important_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Areas
{
    internal class Sea : Area
    {

        internal override string CreateDescription() =>
@"You decided to borrow a boat to travel the sea!
The beasts of the sea have long been corrupted by the evil of Tiamat making them far stronger.

You can 'Continue' to go deeper!
You can 'Leave' and fight another day!
Or you can 'Learn' about the ememies you've fought so far!
";

        internal override void ReceiveChoice(string choice)
        {
            //choice = "continue";
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
