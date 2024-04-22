using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Player_Stuff
{
    internal class Inventory
    {
        public static List<string> monsterDropNames = new List<string>();
        public static List<int> monsterDropAmount = new List<int>();

        public enum Armor
        {
           
        }
        public enum Weapons
        {

        }


        public static void PlayerInventory()
        {
            int x = 0;

            foreach (string i in monsterDropNames)
            {
                if (monsterDropAmount[x] != 0)
                {
                    Console.WriteLine("You have " + monsterDropAmount[x] + " " + monsterDropNames[x]);
                }
                x++;
            }
        }

        public static void PlayerEquipment()
        {

        }
    }
}
