using Final_Project.Important_Stuff;
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
@". 
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "Look":
                    Console.WriteLine("You return to your bedroom.");
                    Game.Transition<Forest>();
                    break;
                case "Escape":
                    Console.WriteLine("The chest opens and you get a key.");
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
