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
            Inventory.monsterDropCost.Insert(2, 2);

            Inventory.monsterDropNames.Insert(3, "Bones");
            Inventory.monsterDropAmount.Insert(3, 0);
            Inventory.monsterDropCost.Insert(3,9);

            Inventory.monsterDropNames.Insert(4, "Spider Poison");
            Inventory.monsterDropAmount.Insert(4, 0);
            Inventory.monsterDropCost.Insert(4, 10);

            Inventory.monsterDropNames.Insert(5, "Bottles of Troll Blood");
            Inventory.monsterDropAmount.Insert(5, 0);
            Inventory.monsterDropCost.Insert(5, 25);

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
