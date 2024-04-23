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
            Inventory.monsterDropCost.Insert(0, 3);

            Inventory.monsterDropNames.Insert(1, "Wolf Pelt");
            Inventory.monsterDropAmount.Insert(1, 0);
            Inventory.monsterDropCost.Insert(1, 6);

            Inventory.monsterDropNames.Insert(2, "Drops of Slime");
            Inventory.monsterDropAmount.Insert(2, 0);
            Inventory.monsterDropCost.Insert(2, 3);

            Inventory.monsterDropNames.Insert(3, "Ogre Toes");
            Inventory.monsterDropAmount.Insert(3, 0);
            Inventory.monsterDropCost.Insert(3, 10);


            Inventory.monsterDropNames.Insert(4, "Bones");
            Inventory.monsterDropAmount.Insert(4, 0);
            Inventory.monsterDropCost.Insert(4,11);

            Inventory.monsterDropNames.Insert(5, "Spider Poison");
            Inventory.monsterDropAmount.Insert(5, 0);
            Inventory.monsterDropCost.Insert(5, 10);

            Inventory.monsterDropNames.Insert(6, "Kobold Eyes");
            Inventory.monsterDropAmount.Insert(6, 0);
            Inventory.monsterDropCost.Insert(6, 15);

            Inventory.monsterDropNames.Insert(7, "Bottles of Troll Blood");
            Inventory.monsterDropAmount.Insert(7, 0);
            Inventory.monsterDropCost.Insert(7, 25);


            Inventory.monsterDropNames.Insert(8, "Manticore Stringer");
            Inventory.monsterDropAmount.Insert(8, 0);
            Inventory.monsterDropCost.Insert(8, 37);

            Inventory.monsterDropNames.Insert(9, "Sheets of Linen");
            Inventory.monsterDropAmount.Insert(9, 0);
            Inventory.monsterDropCost.Insert(9, 30);

            Inventory.monsterDropNames.Insert(10, "Roc Feathers");
            Inventory.monsterDropAmount.Insert(10, 0);
            Inventory.monsterDropCost.Insert(10, 24);

            Inventory.monsterDropNames.Insert(11, "Purple Worm Eggs");
            Inventory.monsterDropAmount.Insert(11, 0);
            Inventory.monsterDropCost.Insert(11, 62);

            Inventory.monsterDropNames.Insert(12, "Gnoll Hide");
            Inventory.monsterDropAmount.Insert(12, 0);
            Inventory.monsterDropCost.Insert(12, 41);


            Inventory.monsterDropNames.Insert(13, "Merfolk Tail");
            Inventory.monsterDropAmount.Insert(13, 0);
            Inventory.monsterDropCost.Insert(13, 100);

            Inventory.monsterDropNames.Insert(14, "Sahuagin Fins");
            Inventory.monsterDropAmount.Insert(14, 0);
            Inventory.monsterDropCost.Insert(14, 70);

            Inventory.monsterDropNames.Insert(15, "Hydra Head");
            Inventory.monsterDropAmount.Insert(15, 0);
            Inventory.monsterDropCost.Insert(15, 160);

            Inventory.monsterDropNames.Insert(16, "Harpy Feathers");
            Inventory.monsterDropAmount.Insert(16, 0);
            Inventory.monsterDropCost.Insert(16, 90);

            Inventory.monsterDropNames.Insert(16, "Kraken Tenticles");
            Inventory.monsterDropAmount.Insert(16, 0);
            Inventory.monsterDropCost.Insert(16, 200);


            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);

            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);
            Inventory.WeaponsList.Add("");
            Inventory.WeaponDamage.Add(0);


            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");

            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
            Inventory.ArmorProtection.Add(0);
            Inventory.ArmorList.Add("");
        }
    }
}
