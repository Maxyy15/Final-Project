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
                    Console.WriteLine("Goblins are weak to Dark and Poison and are resistant to Water!");
                }
                if (wolf == true)
                {
                    Console.WriteLine("Wolves are weak to Poison and are resistant to Air and Earth!");
                }
                if (slime == true) 
                {
                    Console.WriteLine("Slimes are weak to Water and Earth and are resistant to Fire!");
                }
                if (ogre == true)
                {
                    Console.WriteLine("Ogres are weak to Fire and Poison and are resistant to Air and Water!");
                }
            }

            if(Program.currentArea == "cave")
            {
                if (mimic == true)
                {
                    Console.WriteLine("Mimics are weak to Fire and are resistant to Water and Holy!");
                }
                if (skeleton == true)
                {
                    Console.WriteLine("Skeletons are weak to Holy and are resistant to Poison and Dark!");
                }
                if (spider == true)
                {
                    Console.WriteLine("Spiders are weak to Water and Earth and are resistant to Poison!");
                }
                if (troll == true)
                {
                    Console.WriteLine("Trolls are weak to Fire and Poison and are resistant to Earth and Air!");
                }
                if (kobold == true)
                {
                    Console.WriteLine("Kobolds are weak to Fire and Holy are resistant to Poison!");
                }
            }

            if (Program.currentArea == "desert")
            {
                if (manticore == true)
                {
                    Console.WriteLine("Manticores are weak to Holy and Air and are resistant to Water and Dark!");
                }
                if (mummy == true)
                {
                    Console.WriteLine("Mummys are weak to Fire and Holy and are resistant to Poison and Dark!");
                }
                if (roc == true)
                {
                    Console.WriteLine("Rocs are weak to Poison and Dark are resistant to Air, Holy and Earth!");
                }
                if (purpleworm == true)
                {
                    Console.WriteLine("Purple Worms are weak to Water and Poison and are resistant to Fire, Earth and Poison!");
                }
                if (gnoll == true)
                {
                    Console.WriteLine("Gnolls are weak to Earth and Holy are resistant to Poison and Dark!");
                }
            }

            if (Program.currentArea == "sea")
            {
                if (merfolk == true)
                {
                    Console.WriteLine("Merfolk are weak to Dark, Air and Poison and are resistant to Water and Fire!");
                }
                if (sahuagin == true)
                {
                    Console.WriteLine("Sahuagins are weak to Air and Holy and are resistant to Water, Fire and Poison!");
                }
                if (pirate == true)
                {
                    Console.WriteLine("Pirates are weak to Poison and Fire and are resistant to Water, Earth and Air!");
                }
                if (hydra == true)
                {
                    Console.WriteLine("Hydras are weak to Fire and Holy are resistant to Poison, Dark and Water!");
                }
                if (harpy == true)
                {
                    Console.WriteLine("Harpys are weak to Fire and are resistant to Air!");
                }
                if (kraken == true)
                {
                    Console.WriteLine("Krakens are weak to Dark and Air and are resistant to Poison, Water and Fire!");
                }
            }

            if (Program.currentArea == "tiamat's lair")
            {
                if(tiamat == true)
                {
                    Console.WriteLine("Tiamat has only one known weakness, Holy magic. They are resistant to every other form of magic.");
                }    
            }
        }

    }
}
