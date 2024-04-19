using System;
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
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Menu>();
                    break;
                case "home":
                    Console.WriteLine("The chest opens and you get a key.");
                    Game.Transition<Home>();
                    break;
                case "shop":

                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
