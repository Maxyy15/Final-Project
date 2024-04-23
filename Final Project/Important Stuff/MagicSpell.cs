using Final_Project.Player_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Important_Stuff
{
    internal class MagicSpell
    {
        public static void MagicSpells()
        {
        jump:
            Program.adventurer.Big = true;
            Program.cast = true;
            Console.WriteLine("Choose your spell list!\n" + "Type 'Fire' for fire spells\nType 'Water' for water spells\nType 'Air' for air spells\nType 'Earth' for earth spells");
            Console.WriteLine($"Or type 'Nevermind' to go back");

            string spellListChoice = Console.ReadLine().ToLower();

            //whoops:
            //    if (adventurer.Big == false)
            //    {
            //        return;
            //    }

            switch (spellListChoice)
            {

                case "fire":
                    {
                    retry:
                        Magic fireBolt = new Magic("Fire Bolt", "Fire", 15, 5);
                        Magic lightningStrike = new Magic("Lightning Strike", "Fire", 5, 10);
                        Magic fireStrom = new Magic("Fire Storm", "Fire", 30, 18);

                        Console.WriteLine($"'Fire Bolt', it does {fireBolt.magicDamage} damage and it costs {fireBolt.magicCost} Mana\n");

                        if (Program.adventurer.Level >= 5)
                        {
                            Console.WriteLine($"'Lightning Strike', it does {lightningStrike.magicDamage} damage and it costs {lightningStrike.magicCost} Mana\n");
                        }
                        if (Program.adventurer.Level >= 10)
                        {
                            Console.WriteLine($"'Fire Storm', it does {fireStrom.magicDamage} damage and it costs {fireStrom.magicCost} Mana\n");
                        }

                        string spellChoice = Console.ReadLine().ToLower();
                        switch (spellChoice)
                        {
                            case "fire bolt":
                                {
                                    Console.Clear();
                                    if (Program.adventurer.Mana < fireBolt.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Fire Bolt!");
                                        Program.adventurer.currentMagicDamage = fireBolt.magicDamage;
                                        Program.adventurer.currentMagicSpell = fireBolt.magicName;
                                        Program.adventurer.currentMagicCost = fireBolt.magicCost;
                                        Program.adventurer.currentMagicType = fireBolt.magicType;
                                        Program.adventurer.Mana -= fireBolt.magicCost;
                                    }
                                }
                                break;

                            case "lightning strike":
                                {
                                    if (Program.adventurer.Level < 5)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You aren't a high enough level to cast this.");
                                        Program.cast = false;
                                        break;
                                        //goto whoops;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        if (Program.adventurer.Mana < lightningStrike.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Lightning Strike!");
                                            Program.adventurer.currentMagicDamage = lightningStrike.magicDamage;
                                            Program.adventurer.currentMagicSpell = lightningStrike.magicName;
                                            Program.adventurer.currentMagicCost = lightningStrike.magicCost;
                                            Program.adventurer.currentMagicType = lightningStrike.magicType;
                                            Program.adventurer.Mana -= lightningStrike.magicCost;

                                            Random rnd = new Random();

                                            int stunChance = rnd.Next(0, 11);
                                            if (stunChance >= 0 && stunChance <= 3)
                                            {
                                                Program.playerStatusCount = lightningStrike.magicDuration = 2;
                                                Program.adventurer.currentMagicStatus = lightningStrike.magicStatus = "Stun";
                                                Fighting.monster.playerStatusEffect = true;
                                            }


                                        }
                                    }
                                }
                                break;
                            case "fire storm":
                                {
                                    if (Program.adventurer.Level < 10)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You aren't a high enough level to cast this.");
                                        Program.cast = false;
                                        break;
                                        //goto whoops;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        if (Program.adventurer.Mana < fireStrom.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Lightning Strike!");
                                            Program.adventurer.currentMagicDamage = fireStrom.magicDamage;
                                            Program.adventurer.currentMagicSpell = fireStrom.magicName;
                                            Program.adventurer.currentMagicCost = fireStrom.magicCost;
                                            Program.adventurer.currentMagicType = fireStrom.magicType;
                                            Program.adventurer.Mana -= fireStrom.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "nevermind":
                                {
                                    Console.Clear();
                                    Console.WriteLine("You decided to not cast a spell!");
                                    Program.adventurer.Big = false;
                                }
                                break;
                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please enter a valid option!");
                                    goto retry;
                                }
                        }
                    }
                    break;

                case "water":
                    {

                        Magic iceBolt = new Magic("Ice Bolt", "Water", 10, 3);

                        Console.WriteLine($"'Ice Bolt', it does {iceBolt.magicDamage} damage and it costs {iceBolt.magicCost} Mana\n");
                        string spellChoice = Console.ReadLine();
                        switch (spellChoice)
                        {
                            case "ice bolt":
                                {
                                    Console.Clear();
                                    if (Program.adventurer.Mana < iceBolt.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You decided to use Ice Bolt!");
                                        Program.adventurer.currentMagicDamage = iceBolt.magicDamage;
                                        Program.adventurer.currentMagicSpell = iceBolt.magicName;
                                        Program.adventurer.currentMagicCost = iceBolt.magicCost;
                                        Program.adventurer.currentMagicType = iceBolt.magicType;
                                        Program.adventurer.Mana -= iceBolt.magicCost;
                                    }
                                }
                                break;

                            case "nevermind":
                                {
                                    Console.Clear();
                                    Console.WriteLine("You decided to not cast a spell!");
                                    Program.adventurer.Big = false;
                                }
                                break;

                        }
                    }
                    break;

                case "air":
                    {
                        Magic windBlade = new Magic("Wind Blade", "Wind", 20, 8);

                        Console.WriteLine($"'Wind Blade', it does {windBlade.magicDamage} damage and it costs {windBlade.magicCost} Mana\n");
                        string spellChoice = Console.ReadLine();
                        switch (spellChoice)
                        {
                            case "wind blade":
                                {
                                    Console.Clear();
                                    if (Program.adventurer.Mana < windBlade.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You decided to use Wind Blade!");
                                        Program.adventurer.currentMagicDamage = windBlade.magicDamage;
                                        Program.adventurer.currentMagicSpell = windBlade.magicName;
                                        Program.adventurer.currentMagicCost = windBlade.magicCost;
                                        Program.adventurer.currentMagicType = windBlade.magicType;
                                        Program.adventurer.Mana -= windBlade.magicCost;
                                    }
                                }
                                break;

                            case "nevermind":
                                {
                                    Console.Clear();
                                    Console.WriteLine("You decided to not cast a spell!");
                                    Program.adventurer.Big = false;
                                }
                                break;

                        }
                    }
                    break;

                case "earth":
                    {
                        string spellChoice = Console.ReadLine().ToLower();
                        switch (spellChoice)
                        {

                            case "nevermind":
                                {
                                    Console.Clear();
                                    Console.WriteLine("You decided to not cast a spell!");
                                    Program.adventurer.Big = false;
                                }
                                break;
                        }
                    }
                    break;

                case "poison":
                    {
                        Magic poisonStrike = new Magic("Poison Strike", "Poison", 4, 12);

                        Console.WriteLine($"'Poison Strike', it does {poisonStrike.magicDamage} damage and it costs {poisonStrike.magicCost} Mana! It can also poison the target for 7 extra damage!\n");

                        string spellChoice = Console.ReadLine().ToLower();
                        switch (spellChoice)
                        {
                            case "poison strike":
                                Console.Clear();
                                Console.WriteLine("You decided to use Poison Strike!");
                                Program.adventurer.currentMagicDamage = poisonStrike.magicDamage;
                                Program.adventurer.currentMagicSpell = poisonStrike.magicName;
                                Program.adventurer.currentMagicCost = poisonStrike.magicCost;
                                Program.adventurer.currentMagicType = poisonStrike.magicType;
                                Program.adventurer.Mana -= poisonStrike.magicCost;

                                Random rnd = new Random();

                                int poisonChance = rnd.Next(0, 11);
                                poisonChance = 3;
                                if (poisonChance >= 0 && poisonChance <= 4)
                                {
                                    Program.playerStatusCount = poisonStrike.magicDuration = 5;
                                    Program.adventurer.currentMagicStatus = poisonStrike.magicStatus = "Poison";
                                    Fighting.poisonDmg = 7;
                                    Fighting.monster.playerStatusEffect = true;
                                }

                                break;
                            case "nevermind":
                                {
                                    Console.Clear();
                                    Console.WriteLine("You decided to not cast a spell!");
                                    Program.adventurer.Big = false;
                                }
                                break;
                        }
                    }
                    break;

                case "holy":
                    {
                        string spellChoice = Console.ReadLine().ToLower();
                        switch (spellChoice)
                        {
                            case "nevermind":
                                {
                                    Console.Clear();
                                    Console.WriteLine("You decided to not cast a spell!");
                                    Program.adventurer.Big = false;
                                }
                                break;
                        }
                    }
                    break;

                case "dark":
                    {
                        string spellChoice = Console.ReadLine();
                        switch (spellChoice)
                        {
                            case "nevermind":
                                {
                                    Console.Clear();
                                    Console.WriteLine("You decided to not cast a spell!");
                                    Program.adventurer.Big = false;
                                }
                                break;
                        }
                    }
                    break;

                case "nevermind":
                    {
                        Console.Clear();
                        Console.WriteLine("You decided to not cast a spell!");
                        Program.adventurer.Big = false;
                    }
                    break;


                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid option!");
                    }
                    goto jump;

            }

        }
    }
}
