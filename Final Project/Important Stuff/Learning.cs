using Final_Project.Player_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Important_Stuff
{
    internal class Learning
    {
        public static bool goblin = false, wolf = false, slime = false;

        public static void Learn()
        {
            if (Program.currentArea == "forest")
            {

                if (goblin == true)
                {
                    Console.WriteLine("Goblins are weak to Fire and are resistant to Water!");
                }
                if (wolf == true)
                {
                    Console.WriteLine("Wolves are weak to Fire and are resistant to Air and Earth!");
                }
                if (slime == true) 
                {
                    Console.WriteLine("Slimes are weak to Water and are resistant to Fire!");
                }
            }

            if(Program.currentArea == "cave")
            {

            }
        }
    }
}
