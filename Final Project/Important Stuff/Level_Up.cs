using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Important_Stuff
{
    internal class Level_Up
    {
        public static void LevelUp()
        {
            if (Program.adventurer.Exp >= Program.levelUpCost)
            {
            levelUpLoop:

                Program.adventurer.Exp -= Program.levelUpCost;
                Program.adventurer.Level++;
                Program.levelUpCost = (int)(Program.levelUpCost * 1.1);

                Program.maxHP += 10;
                Program.maxMana += 5;

                if (Program.adventurer.Exp >= Program.levelUpCost)
                {
                    goto levelUpLoop;
                }
                else
                {
                    Console.WriteLine($"\nYou leveled up!\nYou are now level {Program.adventurer.Level}! {Program.levelUpCost}");
                }
            }
        }
    }
}
