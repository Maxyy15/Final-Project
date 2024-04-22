using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Areas
{
    internal class AreaList : Area
    {
        internal override string CreateDescription() =>
@"You decided to explore!
Chose from these areas! 
Keep in mind, the further down the list the harder the monsters!
'Forest' - Level 1-5
'Cave' Level 6-10
'Desert' Level 11-15
'Ocean' Level 16-20

'Tiamat's Lair'
";
        internal override void ReceiveChoice(string choice)
        {

            switch (choice)
            {
                case "forest":
                    Program.currentArea = "forest";
                    Game.Transition<Forest>();
                    break;

                case "cave":

                    Console.WriteLine("You decided to go to the cave!");
                    Program.currentArea = "cave";
                    Game.Transition<Cave>();

                    break;

                case "desert":

                    Console.WriteLine("You decided to go to the desert!");
                    Program.currentArea = "desert";
                    break;

                case "ocean":

                    Console.WriteLine("You decided to go to the ocean!");
                    Program.currentArea = "ocean";
                    break;

                case "tiamat's lair":

                    Console.WriteLine("You decided to go to the ocean!");
                    Program.currentArea = "tiamat's lair";
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
    
}
