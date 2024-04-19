using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Player_Stuff
{
    internal class Inventory
    {
        public static List<string> monsterDropNames = new List<string>(100);
        public static List<int> monsterDropAmount = new List<int>(100);

        public enum Armor
        {
           
        }
        public enum Weapons
        {

        }


        public static void PlayerInventory()
        {
            //for(int i = 0; i < monsterDropNames.Count; i++) 
            //{ 
            //    Console.WriteLine($"You have ", monsterDropAmount[i], monsterDropNames[i]);
            //}
            foreach(string i in monsterDropNames)
            {
                foreach (int j in monsterDropAmount)
                {
                    Console.WriteLine(i, j);

                }
            }
        }

        public static void PlayerEquipment()
        {

        }
    }
}
