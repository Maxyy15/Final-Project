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
The shop owner smiles at you, happy to know that their gifts helped you get started.

One room is filled with 'Armor' and the other is filled with 'Weapons'.
You can 'Sell' all the drops you've collected from monsters.
You can also 'Leave' when you're all done.
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
                    Selling.Sell();
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
