using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Player_Stuff
{
    internal class LevelUpSystem
    {
        public static void LevelUp(Player adventurer, ref int levelUpCost, ref int maxHP, ref int maxMana)
        {
            if (adventurer.Exp >= levelUpCost)
            {
                // Level up the adventurer
                adventurer.Exp -= levelUpCost;
                adventurer.Level++;
                levelUpCost = (int)(levelUpCost * 1.2);
                maxHP += 10;
                maxMana += 5;

                // Recursively check for additional level-ups if enough experience is available
                LevelUp(adventurer, ref levelUpCost, ref maxHP, ref maxMana);

                Console.WriteLine($"\nYou leveled up!\nYou are now level {adventurer.Level}! {levelUpCost}");
            }
        }
    }
}
