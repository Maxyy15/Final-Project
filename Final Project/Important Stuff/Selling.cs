using Final_Project.Monsters;
using Final_Project.Player_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Important_Stuff
{
    internal class Selling
    {
        public static void Sell()
        {
            
            int x = 0;
            foreach (string i in Player_Stuff.Inventory.monsterDropNames)
            {
                if (Player_Stuff.Inventory.monsterDropAmount[x] != 0)
                {
                    Console.WriteLine("You have " + Player_Stuff.Inventory.monsterDropAmount[x] + " " + Player_Stuff.Inventory.monsterDropNames[x]);
                }
                x++;
            }
            Console.WriteLine("Do you wish to sell everything?");

            string answer = Console.ReadLine().ToLower();
            Console.Clear();

            switch (answer)
            {
                case "yes":
                    try
                    {
                        x = 0;
                        if (Player_Stuff.Inventory.monsterDropAmount.All(resist => 0 == resist))
                        {
                            Console.WriteLine("You don't have anything to sell!");
                        }
                        else
                        {
                            foreach (string i in Player_Stuff.Inventory.monsterDropNames)
                            {
                            sellagain:
                                if (Player_Stuff.Inventory.monsterDropAmount[x] != 0)
                                {
                                    //Console.WriteLine("You have " + Player_Stuff.Inventory.monsterDropAmount[x] + " " + Player_Stuff.Inventory.monsterDropNames[x]);
                                    Inventory.monsterDropAmount[x] -= 1;
                                    Program.adventurer.Gold += Player_Stuff.Inventory.monsterDropCost[x];
                                    Console.WriteLine(Program.adventurer.Gold);
                                }
                                if (Player_Stuff.Inventory.monsterDropAmount[x] != 0)
                                {
                                    goto sellagain;
                                }
                                x++;
                            }
                            Console.WriteLine("You sold everything!");
                            Console.WriteLine(Program.adventurer.Gold);
                        }

                    }
                    catch (Exception ex) { Console.WriteLine("You don't have anything to sell!"); }
                    break;

                case "no":
                    Console.WriteLine("You decided not sell your stuff!");
                    break;

                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
