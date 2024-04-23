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
        public static bool goblin = false, wolf = false, slime = false, ogre = false, 
            kobold = false, mimic = false, skeleton = false, spider = false, troll = false, 
            gnoll = false, manticore = false, mummy = false, purpleworm = false, roc = false, 
            harpy = false, hydra = false, kraken = false, merfolk = false, pirate = false, sahuagin = false, 
            tiamat = false;

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
                if (ogre == true)
                {
                    Console.WriteLine("Ogre's are weak to Fire and Poison and are resistant to Air and Water!");
                }
            }

            if(Program.currentArea == "cave")
            {

            }

            if (Program.currentArea == "desert")
            {

            }

            if (Program.currentArea == "sea")
            {

            }

            if (Program.currentArea == "tiamat's lair")
            {

            }
        }
    }
}
