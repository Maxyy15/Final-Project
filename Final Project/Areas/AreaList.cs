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
Chose from these areas, but be careful choosing where you go, you may not be strong enough to fight the monsters in certain areas.

'Forest' - Recommended Level 1-5
'Cave' - Recommended Level 6-10
'Desert' - Recommended Level 11-15
'Sea' - Recommended Level 16-20
'Tiamat's Lair' - Recommended Level ???-???
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
                    Program.currentArea = "cave";
                    Game.Transition<Cave>();
                    break;

                case "desert":
                    Program.currentArea = "desert";
                    Game.Transition<Desert>();
                    break;

                case "sea":
                    Program.currentArea = "sea";
                    Game.Transition<Sea>();
                    break;

                case "tiamat's lair":
                    Program.currentArea = "tiamat's lair";
                    Game.Transition<TiamatsLair>();
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
    
}
