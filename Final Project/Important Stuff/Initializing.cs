using Final_Project.Player_Stuff;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final_Project.Important_Stuff
{
    internal class Initializing
    {
        public static void Initialize()
        {
            Inventory.monsterDropNames.Insert(0, "Goblin Teeth");
            Inventory.monsterDropAmount.Insert(0, 0);

            Inventory.monsterDropNames.Insert(1, "Wolf Pelt");
            Inventory.monsterDropAmount.Insert(1, 0);

            Inventory.monsterDropNames.Insert(2, "Drops of Slime");
            Inventory.monsterDropAmount.Insert(2, 0);

            Inventory.monsterDropNames.Insert(3, "Bones");
            Inventory.monsterDropAmount.Insert(3, 0);

            Inventory.monsterDropNames.Insert(4, "Spider Poison");
            Inventory.monsterDropAmount.Insert(4, 0);

            Inventory.monsterDropNames.Insert(5, "Bottles of Troll Blood");
            Inventory.monsterDropAmount.Insert(5, 0);
        }
    }
}
