using Final_Project.Important_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Areas
{
    internal class Shop : Area
    {
        internal override string CreateDescription() =>
@"You've arrived at the shop!
There are two rooms to choose from!
One room is filled with 'Armor' and the other is filled with 'Weapons'!
You can also 'Sell' all the drops you've collected from monsters!
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "armor":
                    Console.WriteLine("You chose to go check out the armor!");
                    Buying.ShopArmor();
                    break;
                case "weapons":
                    Console.WriteLine("You chose to go check out the weapons!");
                    Buying.ShopWeapons();
                    break;
                case "sell":
                    Console.WriteLine("You chose to sell all your items!");
                    break;
                case "leave":
                    Console.WriteLine("You decided to leave!");
                    Game.Transition<Menu>();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
