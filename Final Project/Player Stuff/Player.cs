using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Player
    {
        public string name;
        public int HP = 100;
        public int Mana = 50;
        public int Gold = 5000000;
        public int Exp = 0;
        public int LevelUpCost = 30;
        public int Level = 1;

        public bool Big = false;

        public string currentWeaponName;
        public int currentWeaponDamage = 0;

        public string currentArmorName;
        public int currentArmorProtection = 0;

        public string currentMagicSpell;
        public string currentMagicType;
        public string currentMagicStatus;
        public int currentMagicDamage;
        public int currentMagicCost;
        public void Introduction()
        {
            Console.Write("Hello {0}!\nYou're an adventurer on the quest to stop Tiamat's from destroying the world!\n" +
                "You must collect monster materials and sell them to the shop so you can aquire", name); 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" gold"); 
            Console.ResetColor();
            Console.Write(" to buy better items!\n" +
                "You can explore the areas and learn more about the world you live in!\n" +
                "You can go home to rest up, check your inventory or swap your gear after a fight!\n" +
                "Remember you only have one life, if you");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" die ");
            Console.ResetColor();

            Console.Write("then you lose!\n");
            Console.Write("Press any key to continue!");

        }
    }
}
