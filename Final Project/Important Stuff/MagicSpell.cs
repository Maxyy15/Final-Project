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
            Random rnd = new Random();
            Console.WriteLine("Choose your spell list!\n" + "Type 'Fire' for fire spells\nType 'Water' for water spells\nType 'Air' for air spells\nType 'Earth' for earth spells\n" +
                "Type 'Poison' for poison spells\nType 'Holy' for holy spells\nType 'Dark' for dark spells");
            Console.WriteLine($"Or type 'Cancel' to go back");

            string spellListChoice = Console.ReadLine().ToLower();

            switch (spellListChoice)
            {

                case "fire":
                    {
                    retry:
                        //Sunfire Nova
                        Magic fireBolt = new Magic("Fire Bolt", "Fire", 5, 5); //1
                        Magic lightningStrike = new Magic("Lightning Strike", "Fire", 25, 12);//5
                        Magic fireStrom = new Magic("Fire Storm", "Fire", 65, 22); //10
                        Magic orbOfElectricity = new Magic("Orb of Electricity", "Fire", 45, 40);//15
                        Magic runicBlaze = new Magic("Runic Blaze", "Fire", 75, 45); //20
                        Magic hellfireBlitz = new Magic("Hellfire Blitz", "Fire", 120, 70); //25
                        Magic electricShower = new Magic("Electric Shower", "Fire", 150, 125); //30
                        Magic solarSpike = new Magic("Solar Spike", "Fire", 200, 100); //35

                        Console.WriteLine($"'Fire Bolt', it does {fireBolt.magicDamage} damage\nIt costs {fireBolt.magicCost} Mana\nIt has a 10% chance to fail!\n");

                        if (Program.adventurer.Level >= 5)
                        {
                            Console.WriteLine($"'Lightning Strike', it does {lightningStrike.magicDamage} damage\nIt costs {lightningStrike.magicCost} Mana\nIt had a 20% chance to fail\n");
                        }

                        if (Program.adventurer.Level >= 10)
                        {
                            Console.WriteLine($"'Fire Storm', it does {fireStrom.magicDamage} damage\nIt costs {fireStrom.magicCost} Mana\nIt has a 25% chance to fail");
                        }

                        if (Program.adventurer.Level >= 15)
                        {
                            Console.WriteLine($"'Orb of Electricity', it does {orbOfElectricity.magicDamage} damage\nIt costs {orbOfElectricity.magicCost} Mana\nIt has a 25% chance to fail");
                        }

                        if (Program.adventurer.Level >= 20)
                        {
                            Console.WriteLine($"'Runic Blaze', it does {runicBlaze.magicDamage} damage\nIt costs {runicBlaze.magicCost} Mana\nIt has a 25% chance to fail");
                        }

                        if (Program.adventurer.Level >= 25)
                        {
                            Console.WriteLine($"'Hellfire Blitz', it does {hellfireBlitz.magicDamage} damage\nIt costs {hellfireBlitz.magicCost} Mana\nIt has a 25% chance to fail");
                        }

                        if (Program.adventurer.Level >= 30)
                        {
                            Console.WriteLine($"'Electric Shower', it does {electricShower.magicDamage} damage\nIt costs {electricShower.magicCost} Mana\nIt has a 25% chance to fail");
                        }

                        if (Program.adventurer.Level >= 35)
                        {
                            Console.WriteLine($"'Solar Spike', it does {solarSpike.magicDamage} damage\nIt costs {solarSpike.magicCost} Mana\nIt has a 25% chance to fail");
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
                                        Program.adventurer.magicHitChance = rnd.Next(0, 101);
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
                                            Program.adventurer.magicHitChance = rnd.Next(0, 51);
                                            Program.adventurer.currentMagicDamage = lightningStrike.magicDamage;
                                            Program.adventurer.currentMagicSpell = lightningStrike.magicName;
                                            Program.adventurer.currentMagicCost = lightningStrike.magicCost;
                                            Program.adventurer.currentMagicType = lightningStrike.magicType;
                                            Program.adventurer.Mana -= lightningStrike.magicCost;

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
                                            Console.WriteLine("You decided to use Fire Strom!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                            Program.adventurer.currentMagicDamage = fireStrom.magicDamage;
                                            Program.adventurer.currentMagicSpell = fireStrom.magicName;
                                            Program.adventurer.currentMagicCost = fireStrom.magicCost;
                                            Program.adventurer.currentMagicType = fireStrom.magicType;
                                            Program.adventurer.Mana -= fireStrom.magicCost;
                                        }
                                    }
                                }
                                break;

                            case "orb of electricity":
                                if (Program.adventurer.Level < 15)
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
                                    if (Program.adventurer.Mana < orbOfElectricity.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Orb of Electricity!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = orbOfElectricity.magicDamage;
                                        Program.adventurer.currentMagicSpell = orbOfElectricity.magicName;
                                        Program.adventurer.currentMagicCost = orbOfElectricity.magicCost;
                                        Program.adventurer.currentMagicType = orbOfElectricity.magicType;
                                        Program.adventurer.Mana -= orbOfElectricity.magicCost;

                                        int stunChance = rnd.Next(0, 11);
                                        if (stunChance >= 0 && stunChance <= 3)
                                        {
                                            Program.playerStatusCount = orbOfElectricity.magicDuration = 3;
                                            Program.adventurer.currentMagicStatus = orbOfElectricity.magicStatus = "Stun";
                                            Fighting.monster.playerStatusEffect = true;
                                        }

                                    }
                                }
                                break;
                            case "runic blaze":
                                if (Program.adventurer.Level < 20)
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
                                    if (Program.adventurer.Mana < runicBlaze.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Runic Blaze!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = runicBlaze.magicDamage;
                                        Program.adventurer.currentMagicSpell = runicBlaze.magicName;
                                        Program.adventurer.currentMagicCost = runicBlaze.magicCost;
                                        Program.adventurer.currentMagicType = runicBlaze.magicType;
                                        Program.adventurer.Mana -= runicBlaze.magicCost;
                                    }
                                }
                                break;
                            case "hellfire blitz":
                                if (Program.adventurer.Level < 25)
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
                                    if (Program.adventurer.Mana < hellfireBlitz.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Hellfire Blitz!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = hellfireBlitz.magicDamage;
                                        Program.adventurer.currentMagicSpell = hellfireBlitz.magicName;
                                        Program.adventurer.currentMagicCost = hellfireBlitz.magicCost;
                                        Program.adventurer.currentMagicType = hellfireBlitz.magicType;
                                        Program.adventurer.Mana -= hellfireBlitz.magicCost;
                                    }
                                }
                                break;
                            case "electric shower":
                                if (Program.adventurer.Level < 30)
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
                                    if (Program.adventurer.Mana < electricShower.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Electric Shower!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = electricShower.magicDamage;
                                        Program.adventurer.currentMagicSpell = electricShower.magicName;
                                        Program.adventurer.currentMagicCost = electricShower.magicCost;
                                        Program.adventurer.currentMagicType = electricShower.magicType;
                                        Program.adventurer.Mana -= electricShower.magicCost;

                                        int stunChance = rnd.Next(0, 11);
                                        if (stunChance >= 0 && stunChance <= 4)
                                        {
                                            Program.playerStatusCount = lightningStrike.magicDuration = 4;
                                            Program.adventurer.currentMagicStatus = lightningStrike.magicStatus = "Stun";
                                            Fighting.monster.playerStatusEffect = true;
                                        }

                                    }
                                }
                                break;
                            case "solar spike":
                                if (Program.adventurer.Level < 35)
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
                                    if (Program.adventurer.Mana < solarSpike.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Solar Spike!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = solarSpike.magicDamage;
                                        Program.adventurer.currentMagicSpell = solarSpike.magicName;
                                        Program.adventurer.currentMagicCost = solarSpike.magicCost;
                                        Program.adventurer.currentMagicType = solarSpike.magicType;
                                        Program.adventurer.Mana -= solarSpike.magicCost;
                                    }
                                }
                                break;

                            case "cancel":
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
                    retry:
                        //Fortitude of Frost
                        Magic iceBolt = new Magic("Ice Bolt", "Water", 10, 6); //1
                        Magic aquaWhip = new Magic("Aqua Whip", "Water", 18, 8); //5
                        Magic frostbiteTorrent = new Magic("Frostbite Torrent", "Water", 25, 12); //10
                        Magic abyssalWhirl = new Magic("Abyssal Whirl", "Water", 40, 21); //15
                        Magic sirensSerenade = new Magic("Siren's Seranade", "Water", 30, 50); //20
                        Magic glacierGrasp = new Magic("Glacier Grasp", "Water", 100, 50); //25
                        Magic waveOfFreezing = new Magic("Wave of Freezing", "Water", 70, 40); //30
                        Magic neptunesFury = new Magic("Neptune's Fury", "Water", 60, 34); //35


                        Console.WriteLine($"'Ice Bolt', it does {iceBolt.magicDamage} damage\nIt costs {iceBolt.magicCost} Mana\n");

                        if (Program.adventurer.Level >= 5)
                        {
                            Console.WriteLine($"'Aqua Whip', it does {aquaWhip.magicDamage} damage\nIt costs {aquaWhip.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 10)
                        {
                            Console.WriteLine($"'Frostbite Torrent', it does {frostbiteTorrent.magicDamage} damage\nIt costs {frostbiteTorrent.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 15)
                        {
                            Console.WriteLine($"'Abyssal Whirl', it does {abyssalWhirl.magicDamage} damage\nIt costs {abyssalWhirl.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 20)
                        {
                            Console.WriteLine($"'Siren's Seranade', it does {sirensSerenade.magicDamage} damage\nIt costs {sirensSerenade.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 25)
                        {
                            Console.WriteLine($"'Glacier Grasp', it does {glacierGrasp.magicDamage} damage\nIt costs {glacierGrasp.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 30)
                        {
                            Console.WriteLine($"'Wave of Freezing', it does {waveOfFreezing.magicDamage} damage\nIt costs {waveOfFreezing.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 35)
                        {
                            Console.WriteLine($"'Neptune's Fury', it does {neptunesFury.magicDamage} damage\nIt costs {neptunesFury.magicCost} Mana\n");
                        }

                        string spellChoice = Console.ReadLine().ToLower();
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
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Ice Bolt!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 101);
                                        Program.adventurer.currentMagicDamage = iceBolt.magicDamage;
                                        Program.adventurer.currentMagicSpell = iceBolt.magicName;
                                        Program.adventurer.currentMagicCost = iceBolt.magicCost;
                                        Program.adventurer.currentMagicType = iceBolt.magicType;
                                        Program.adventurer.Mana -= iceBolt.magicCost;
                                    }
                                }
                                break;
                            case "aqua whip":
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
                                        if (Program.adventurer.Mana < aquaWhip.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Aqua Whip!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 51);
                                            Program.adventurer.currentMagicDamage = aquaWhip.magicDamage;
                                            Program.adventurer.currentMagicSpell = aquaWhip.magicName;
                                            Program.adventurer.currentMagicCost = aquaWhip.magicCost;
                                            Program.adventurer.currentMagicType = aquaWhip.magicType;
                                            Program.adventurer.Mana -= aquaWhip.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "frostbite torrent":
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
                                        if (Program.adventurer.Mana < frostbiteTorrent.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Frostbite Torrent!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                            Program.adventurer.currentMagicDamage = frostbiteTorrent.magicDamage;
                                            Program.adventurer.currentMagicSpell = frostbiteTorrent.magicName;
                                            Program.adventurer.currentMagicCost = frostbiteTorrent.magicCost;
                                            Program.adventurer.currentMagicType = frostbiteTorrent.magicType;
                                            Program.adventurer.Mana -= frostbiteTorrent.magicCost;
                                        }
                                    }
                                }
                                break;

                            case "abyssal whirl":
                                if (Program.adventurer.Level < 15)
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
                                    if (Program.adventurer.Mana < abyssalWhirl.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Abyssal Whirl!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = abyssalWhirl.magicDamage;
                                        Program.adventurer.currentMagicSpell = abyssalWhirl.magicName;
                                        Program.adventurer.currentMagicCost = abyssalWhirl.magicCost;
                                        Program.adventurer.currentMagicType = abyssalWhirl.magicType;
                                        Program.adventurer.Mana -= abyssalWhirl.magicCost;
                                    }
                                }
                                break;
                            case "siren's serenade":
                                if (Program.adventurer.Level < 20)
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
                                    if (Program.adventurer.Mana < sirensSerenade.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Siren's Serenade!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = sirensSerenade.magicDamage;
                                        Program.adventurer.currentMagicSpell = sirensSerenade.magicName;
                                        Program.adventurer.currentMagicCost = sirensSerenade.magicCost;
                                        Program.adventurer.currentMagicType = sirensSerenade.magicType;
                                        Program.adventurer.Mana -= sirensSerenade.magicCost;
                                    }
                                }
                                break;
                            case "glacier grasp":
                                if (Program.adventurer.Level < 25)
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
                                    if (Program.adventurer.Mana < glacierGrasp.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Lightning Strike!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = glacierGrasp.magicDamage;
                                        Program.adventurer.currentMagicSpell = glacierGrasp.magicName;
                                        Program.adventurer.currentMagicCost = glacierGrasp.magicCost;
                                        Program.adventurer.currentMagicType = glacierGrasp.magicType;
                                        Program.adventurer.Mana -= glacierGrasp.magicCost;
                                    }
                                }
                                break;
                            case "wave of freezing":
                                if (Program.adventurer.Level < 30)
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
                                    if (Program.adventurer.Mana < waveOfFreezing.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Lightning Strike!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = waveOfFreezing.magicDamage;
                                        Program.adventurer.currentMagicSpell = waveOfFreezing.magicName;
                                        Program.adventurer.currentMagicCost = waveOfFreezing.magicCost;
                                        Program.adventurer.currentMagicType = waveOfFreezing.magicType;
                                        Program.adventurer.Mana -= waveOfFreezing.magicCost;
                                    }
                                }
                                break;
                            case "neptune's fury":
                                if (Program.adventurer.Level < 35)
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
                                    if (Program.adventurer.Mana < neptunesFury.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Lightning Strike!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = neptunesFury.magicDamage;
                                        Program.adventurer.currentMagicSpell = neptunesFury.magicName;
                                        Program.adventurer.currentMagicCost = neptunesFury.magicCost;
                                        Program.adventurer.currentMagicType = neptunesFury.magicType;
                                        Program.adventurer.Mana -= neptunesFury.magicCost;
                                    }
                                }
                                break;

                            case "cancel":
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

                case "air":
                    {
                    retry:
                        Magic windBlade = new Magic("Wind Blade", "Wind", 8, 4); //1 
                        Magic gustGuillotine= new Magic("Gust Guillotine", "Wind", 18, 7); //5
                        Magic aerobladeSlash= new Magic("Aeroblade Slash", "Wind", 29, 16); //10
                        Magic whirlwindWhiplash= new Magic("Whirlwind Whiplash", "Wind", 42, 34); //15
                        Magic typhoonThrust= new Magic("Typhoon Thrust", "Wind", 60, 45); //20
                        Magic cycloneSurge= new Magic("Cyclone Surge", "Wind", 100, 75); //25
                        Magic tempestTornado= new Magic("Tempest Tornado", "Wind", 140, 110); //30
                        Magic zephyrsWrath= new Magic("Zephyr's Wrath", "Wind", 200, 175); //35

                        Console.WriteLine($"'Wind Blade', it does {windBlade.magicDamage} damage\nIt costs {windBlade.magicCost} Mana\n");

                        if (Program.adventurer.Level >= 5)
                        {
                            Console.WriteLine($"'Gust Guillotine', it does {gustGuillotine.magicDamage} damage\nIt costs {gustGuillotine.magicCost} Mana\n");
                        }
                        if (Program.adventurer.Level >= 10)
                        {
                            Console.WriteLine($"'Aeroblade Slash', it does {aerobladeSlash.magicDamage} damage\nIt costs {aerobladeSlash.magicCost} Mana\n");
                        }
                        if (Program.adventurer.Level >= 15)
                        {
                            Console.WriteLine($"'Whirlwind Whiplash', it does {whirlwindWhiplash.magicDamage} damage\nIt costs {whirlwindWhiplash.magicCost} Mana\n");
                        }
                        if (Program.adventurer.Level >= 20)
                        {
                            Console.WriteLine($"'Typhoon Thrust', it does {typhoonThrust.magicDamage} damage\nIt costs {typhoonThrust.magicCost} Mana\n");
                        }
                        if (Program.adventurer.Level >= 25)
                        {
                            Console.WriteLine($"'Cyclone Surge', it does {cycloneSurge.magicDamage} damage\nIt costs {cycloneSurge.magicCost} Mana\n");
                        }
                        if (Program.adventurer.Level >= 30)
                        {
                            Console.WriteLine($"'Tempest Tornado', it does {tempestTornado.magicDamage} damage\nIt costs {tempestTornado.magicCost} Mana\n");
                        }
                        if (Program.adventurer.Level >= 35)
                        {
                            Console.WriteLine($"'Zephyr's Wrath', it does {zephyrsWrath.magicDamage} damage\nIt costs {zephyrsWrath.magicCost} Mana\n");
                        }

                        string spellChoice = Console.ReadLine().ToLower();
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
                                        Program.adventurer.magicHitChance = rnd.Next(0, 101);
                                        Program.adventurer.currentMagicDamage = windBlade.magicDamage;
                                        Program.adventurer.currentMagicSpell = windBlade.magicName;
                                        Program.adventurer.currentMagicCost = windBlade.magicCost;
                                        Program.adventurer.currentMagicType = windBlade.magicType;
                                        Program.adventurer.Mana -= windBlade.magicCost;
                                    }
                                }
                                break;

                            case "gust guillotine":
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
                                        if (Program.adventurer.Mana < gustGuillotine.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Gust Guillotine!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 51);
                                            Program.adventurer.currentMagicDamage = gustGuillotine.magicDamage;
                                            Program.adventurer.currentMagicSpell = gustGuillotine.magicName;
                                            Program.adventurer.currentMagicCost = gustGuillotine.magicCost;
                                            Program.adventurer.currentMagicType = gustGuillotine.magicType;
                                            Program.adventurer.Mana -= gustGuillotine.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "aeroblade slash":
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
                                        if (Program.adventurer.Mana < aerobladeSlash.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Aeroblade Slash!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                            Program.adventurer.currentMagicDamage = aerobladeSlash.magicDamage;
                                            Program.adventurer.currentMagicSpell = aerobladeSlash.magicName;
                                            Program.adventurer.currentMagicCost = aerobladeSlash.magicCost;
                                            Program.adventurer.currentMagicType = aerobladeSlash.magicType;
                                            Program.adventurer.Mana -= aerobladeSlash.magicCost;
                                        }
                                    }
                                }
                                break;

                            case "Whirlwind Whiplash":
                                if (Program.adventurer.Level < 15)
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
                                    if (Program.adventurer.Mana < whirlwindWhiplash.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Whirlwind Whiplash!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = whirlwindWhiplash.magicDamage;
                                        Program.adventurer.currentMagicSpell = whirlwindWhiplash.magicName;
                                        Program.adventurer.currentMagicCost = whirlwindWhiplash.magicCost;
                                        Program.adventurer.currentMagicType = whirlwindWhiplash.magicType;
                                        Program.adventurer.Mana -= whirlwindWhiplash.magicCost;
                                    }
                                }
                                break;
                            case "typhoon thrust":
                                if (Program.adventurer.Level < 20)
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
                                    if (Program.adventurer.Mana < typhoonThrust.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Typhoon Thrust!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = typhoonThrust.magicDamage;
                                        Program.adventurer.currentMagicSpell = typhoonThrust.magicName;
                                        Program.adventurer.currentMagicCost = typhoonThrust.magicCost;
                                        Program.adventurer.currentMagicType = typhoonThrust.magicType;
                                        Program.adventurer.Mana -= typhoonThrust.magicCost;
                                    }
                                }
                                break;
                            case "cyclone surge":
                                if (Program.adventurer.Level < 25)
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
                                    if (Program.adventurer.Mana < cycloneSurge.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Cyclone Surge!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = cycloneSurge.magicDamage;
                                        Program.adventurer.currentMagicSpell = cycloneSurge.magicName;
                                        Program.adventurer.currentMagicCost = cycloneSurge.magicCost;
                                        Program.adventurer.currentMagicType = cycloneSurge.magicType;
                                        Program.adventurer.Mana -= cycloneSurge.magicCost;
                                    }
                                }
                                break;
                            case "tempest tornado":
                                if (Program.adventurer.Level < 30)
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
                                    if (Program.adventurer.Mana < tempestTornado.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Tempest Tornado!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = tempestTornado.magicDamage;
                                        Program.adventurer.currentMagicSpell = tempestTornado.magicName;
                                        Program.adventurer.currentMagicCost = tempestTornado.magicCost;
                                        Program.adventurer.currentMagicType = tempestTornado.magicType;
                                        Program.adventurer.Mana -= tempestTornado.magicCost;
                                    }
                                }
                                break;
                            case "zephyr's wrath":
                                if (Program.adventurer.Level < 35)
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
                                    if (Program.adventurer.Mana < zephyrsWrath.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Zephyr's Wrath!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = zephyrsWrath.magicDamage;
                                        Program.adventurer.currentMagicSpell = zephyrsWrath.magicName;
                                        Program.adventurer.currentMagicCost = zephyrsWrath.magicCost;
                                        Program.adventurer.currentMagicType = zephyrsWrath.magicType;
                                        Program.adventurer.Mana -= zephyrsWrath.magicCost;
                                    }
                                }
                                break;

                            case "cancel":
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

                case "earth":
                    {
                    retry: 
                        Magic rockSmash = new Magic("Rock Smash", "Earth", 6, 3); //1
                        Magic dustCloud= new Magic("Dust Cloud", "Earth", 2, 9); //5
                        Magic terraBurst= new Magic("Terra Burst", "Earth", 15, 8); //10
                        Magic seismicShockwave= new Magic("Seismic Shockwave", "Earth", 20, 16); //15
                        Magic boulderBarrage= new Magic("Boulder Barrage", "Earth", 50, 31); //20
                        Magic mountainMaelstrom= new Magic("Mountain Maelstrom", "Earth", 80, 65); //25
                        Magic tectonicTremor= new Magic("Tectonic Tremor", "Earth", 46, 82); //30
                        Magic gaiasWrath= new Magic("Gaia's Wrath", "Earth", 145, 110); //35

                        Console.WriteLine($"'Rock Smash', it does {rockSmash.magicDamage} damage\nIt costs {rockSmash.magicCost} Mana\n");

                        if (Program.adventurer.Level >= 5)
                        {
                            Console.WriteLine($"'Dust Cloud', it does {dustCloud.magicDamage} damage\nIt costs {dustCloud.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 10)
                        {
                            Console.WriteLine($"'Terra Burst', it does {terraBurst.magicDamage} damage\nIt costs {terraBurst.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 15)
                        {
                            Console.WriteLine($"'Seismic Shockwave', it does {seismicShockwave.magicDamage} damage\nIt costs {seismicShockwave.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 20)
                        {
                            Console.WriteLine($"'Boulder Barrage', it does {boulderBarrage.magicDamage} damage\nIt costs {boulderBarrage.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 25)
                        {
                            Console.WriteLine($"'Mountain Maelstrom', it does {mountainMaelstrom.magicDamage} damage\nIt costs {mountainMaelstrom.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 30)
                        {
                            Console.WriteLine($"'Tectonic Tremor', it does {tectonicTremor.magicDamage} damage\nIt costs {tectonicTremor.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 35)
                        {
                            Console.WriteLine($"'Gaia's Wrath', it does {gaiasWrath.magicDamage} damage\nIt costs {gaiasWrath.magicCost} Mana\n");
                        }

                        string spellChoice = Console.ReadLine().ToLower();
                        switch (spellChoice)
                        {
                            case "rock smash":
                                {
                                    Console.Clear();
                                    if (Program.adventurer.Mana < rockSmash.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Rock Smash!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 101);
                                        Program.adventurer.currentMagicDamage = rockSmash.magicDamage;
                                        Program.adventurer.currentMagicSpell = rockSmash.magicName;
                                        Program.adventurer.currentMagicCost = rockSmash.magicCost;
                                        Program.adventurer.currentMagicType = rockSmash.magicType;
                                        Program.adventurer.Mana -= rockSmash.magicCost;
                                    }
                                }
                                break;
                            case "dust cloud":
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
                                        if (Program.adventurer.Mana < dustCloud.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Dust Cloud!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 51);
                                            Program.adventurer.currentMagicDamage = dustCloud.magicDamage;
                                            Program.adventurer.currentMagicSpell = dustCloud.magicName;
                                            Program.adventurer.currentMagicCost = dustCloud.magicCost;
                                            Program.adventurer.currentMagicType = dustCloud.magicType;
                                            Program.adventurer.Mana -= dustCloud.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "terra burst":
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
                                        if (Program.adventurer.Mana < terraBurst.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Terra Burst!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                            Program.adventurer.currentMagicDamage = terraBurst.magicDamage;
                                            Program.adventurer.currentMagicSpell = terraBurst.magicName;
                                            Program.adventurer.currentMagicCost = terraBurst.magicCost;
                                            Program.adventurer.currentMagicType = terraBurst.magicType;
                                            Program.adventurer.Mana -= terraBurst.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "seismic shockwave":
                                if (Program.adventurer.Level < 15)
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
                                    if (Program.adventurer.Mana < seismicShockwave.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Seismic Shockwave!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = seismicShockwave.magicDamage;
                                        Program.adventurer.currentMagicSpell = seismicShockwave.magicName;
                                        Program.adventurer.currentMagicCost = seismicShockwave.magicCost;
                                        Program.adventurer.currentMagicType = seismicShockwave.magicType;
                                        Program.adventurer.Mana -= seismicShockwave.magicCost;
                                    }
                                }
                                break;
                            case "boulder barrage":
                                if (Program.adventurer.Level < 20)
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
                                    if (Program.adventurer.Mana < boulderBarrage.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Boulder Barrage!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = boulderBarrage.magicDamage;
                                        Program.adventurer.currentMagicSpell = boulderBarrage.magicName;
                                        Program.adventurer.currentMagicCost = boulderBarrage.magicCost;
                                        Program.adventurer.currentMagicType = boulderBarrage.magicType;
                                        Program.adventurer.Mana -= boulderBarrage.magicCost;
                                    }
                                }
                                break;
                            case "mountain maelstrom":
                                if (Program.adventurer.Level < 25)
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
                                    if (Program.adventurer.Mana < mountainMaelstrom.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Lightning Strike!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = mountainMaelstrom.magicDamage;
                                        Program.adventurer.currentMagicSpell = mountainMaelstrom.magicName;
                                        Program.adventurer.currentMagicCost = mountainMaelstrom.magicCost;
                                        Program.adventurer.currentMagicType = mountainMaelstrom.magicType;
                                        Program.adventurer.Mana -= mountainMaelstrom.magicCost;
                                    }
                                }
                                break;
                            case "tectonic tremor":
                                if (Program.adventurer.Level < 30)
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
                                    if (Program.adventurer.Mana < tectonicTremor.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Lightning Strike!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = tectonicTremor.magicDamage;
                                        Program.adventurer.currentMagicSpell = tectonicTremor.magicName;
                                        Program.adventurer.currentMagicCost = tectonicTremor.magicCost;
                                        Program.adventurer.currentMagicType = tectonicTremor.magicType;
                                        Program.adventurer.Mana -= tectonicTremor.magicCost;
                                    }
                                }
                                break;
                            case "gaia's wrath":
                                if (Program.adventurer.Level < 35)
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
                                    if (Program.adventurer.Mana < gaiasWrath.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Lightning Strike!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = gaiasWrath.magicDamage;
                                        Program.adventurer.currentMagicSpell = gaiasWrath.magicName;
                                        Program.adventurer.currentMagicCost = gaiasWrath.magicCost;
                                        Program.adventurer.currentMagicType = gaiasWrath.magicType;
                                        Program.adventurer.Mana -= gaiasWrath.magicCost;
                                    }
                                }
                                break;
                            case "cancel":
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

                case "poison":
                    {
                    retry:
                        Magic poisonStrike = new Magic("Poison Strike", "Poison", 4, 10); //1 
                        Magic noxiousRage= new Magic("Noxious Rage", "Poison", 9, 21);//5 
                        Magic miasmaMist= new Magic("Miasma Mist", "Poison", 17, 37);//10 
                        Magic giftOfDecay= new Magic("Gift of Decay", "Poison", 28, 43);//15 
                        Magic toxicVortex= new Magic("Toxic Vortex", "Poison",35, 56);//20 
                        Magic blastOfBlight = new Magic("Blast of Blight", "Poison", 50, 74);//25
                        Magic corrosiveFlux= new Magic("Corrosive Flux", "Poison", 84, 112); //30 
                        Magic plagueBreath= new Magic("Plague Breath", "Poison", 102, 107);//35


                        Console.WriteLine($"'Poison Strike', it does {poisonStrike.magicDamage} damage\nIt costs {poisonStrike.magicCost} Mana\n" +
                            $"It can also poison the target for 7 extra damage!\n");

                        if (Program.adventurer.Level >= 5)
                        {
                            Console.WriteLine($"'Noxious Rage', it does {noxiousRage.magicDamage} damage\nIt costs {noxiousRage.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 10)
                        {
                            Console.WriteLine($"'Miasma Mist', it does {miasmaMist.magicDamage} damage\nIt costs {miasmaMist.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 15)
                        {
                            Console.WriteLine($"'Gift of Decay', it does {giftOfDecay.magicDamage} damage\nIt costs {giftOfDecay.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 20)
                        {
                            Console.WriteLine($"'Toxic Vortex', it does {toxicVortex.magicDamage} damage\nIt costs {toxicVortex.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 25)
                        {
                            Console.WriteLine($"'Blast of Blight', it does {blastOfBlight.magicDamage} damage\nIt costs {blastOfBlight.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 30)
                        {
                            Console.WriteLine($"'Corrosive Flux', it does {corrosiveFlux.magicDamage} damage\nIt costs {corrosiveFlux.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 35)
                        {
                            Console.WriteLine($"'Plague Breath', it does {plagueBreath.magicDamage} damage\nIt costs {plagueBreath.magicCost} Mana\n");
                        }

                        string spellChoice = Console.ReadLine().ToLower();
                        switch (spellChoice)
                        {
                            case "poison strike":
                                Console.Clear();
                                Console.WriteLine("You decided to use Poison Strike!");
                                Program.adventurer.magicHitChance = rnd.Next(0, 101);
                                Program.adventurer.currentMagicDamage = poisonStrike.magicDamage;
                                Program.adventurer.currentMagicSpell = poisonStrike.magicName;
                                Program.adventurer.currentMagicCost = poisonStrike.magicCost;
                                Program.adventurer.currentMagicType = poisonStrike.magicType;
                                Program.adventurer.Mana -= poisonStrike.magicCost;

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
                            case "noxious rage":
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
                                        if (Program.adventurer.Mana < noxiousRage.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Noxious Rage!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 51);
                                            Program.adventurer.currentMagicDamage = noxiousRage.magicDamage;
                                            Program.adventurer.currentMagicSpell = noxiousRage.magicName;
                                            Program.adventurer.currentMagicCost = noxiousRage.magicCost;
                                            Program.adventurer.currentMagicType = noxiousRage.magicType;
                                            Program.adventurer.Mana -= noxiousRage.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "miasma mist":
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
                                        if (Program.adventurer.Mana < miasmaMist.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Miasma Mist!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                            Program.adventurer.currentMagicDamage = miasmaMist.magicDamage;
                                            Program.adventurer.currentMagicSpell = miasmaMist.magicName;
                                            Program.adventurer.currentMagicCost = miasmaMist.magicCost;
                                            Program.adventurer.currentMagicType = miasmaMist.magicType;
                                            Program.adventurer.Mana -= miasmaMist.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "gift of decay":
                                if (Program.adventurer.Level < 15)
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
                                    if (Program.adventurer.Mana < giftOfDecay.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Gift of Decay!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = giftOfDecay.magicDamage;
                                        Program.adventurer.currentMagicSpell = giftOfDecay.magicName;
                                        Program.adventurer.currentMagicCost = giftOfDecay.magicCost;
                                        Program.adventurer.currentMagicType = giftOfDecay.magicType;
                                        Program.adventurer.Mana -= giftOfDecay.magicCost;
                                    }
                                }
                                break;
                            case "toxic vortex":
                                if (Program.adventurer.Level < 20)
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
                                    if (Program.adventurer.Mana < toxicVortex.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Toxic Vortex!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = toxicVortex.magicDamage;
                                        Program.adventurer.currentMagicSpell = toxicVortex.magicName;
                                        Program.adventurer.currentMagicCost = toxicVortex.magicCost;
                                        Program.adventurer.currentMagicType = toxicVortex.magicType;
                                        Program.adventurer.Mana -= toxicVortex.magicCost;
                                    }
                                }
                                break;
                            case "blast of blight":
                                if (Program.adventurer.Level < 25)
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
                                    if (Program.adventurer.Mana < blastOfBlight.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Blase of Blight!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = blastOfBlight.magicDamage;
                                        Program.adventurer.currentMagicSpell = blastOfBlight.magicName;
                                        Program.adventurer.currentMagicCost = blastOfBlight.magicCost;
                                        Program.adventurer.currentMagicType = blastOfBlight.magicType;
                                        Program.adventurer.Mana -= blastOfBlight.magicCost;
                                    }
                                }
                                break;
                            case "corrosive flux":
                                if (Program.adventurer.Level < 30)
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
                                    if (Program.adventurer.Mana < corrosiveFlux.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Corrosive Flux!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = corrosiveFlux.magicDamage;
                                        Program.adventurer.currentMagicSpell = corrosiveFlux.magicName;
                                        Program.adventurer.currentMagicCost = corrosiveFlux.magicCost;
                                        Program.adventurer.currentMagicType = corrosiveFlux.magicType;
                                        Program.adventurer.Mana -= corrosiveFlux.magicCost;
                                    }
                                }
                                break;
                            case "plague breath":
                                if (Program.adventurer.Level < 35)
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
                                    if (Program.adventurer.Mana < plagueBreath.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Plague Breath!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = plagueBreath.magicDamage;
                                        Program.adventurer.currentMagicSpell = plagueBreath.magicName;
                                        Program.adventurer.currentMagicCost = plagueBreath.magicCost;
                                        Program.adventurer.currentMagicType = plagueBreath.magicType;
                                        Program.adventurer.Mana -= plagueBreath.magicCost;
                                    }
                                }
                                break;

                            case "cancel":
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

                case "holy":
                    {
                    retry:
                        Magic lifeBomb= new Magic("Life Bomb", "Holy", 10, 10); //1 
                        Magic burstOfRecovery= new Magic("Burst of Recovery", "Holy", 18, 13);//5 
                        Magic virtueOfLife= new Magic("Virtue of Life", "Holy",31 , 21);//10 
                        Magic purifyingSmite= new Magic("Purifying Smite", "Holy", 60, 45);//15 
                        Magic wrathOfRadiance= new Magic("Wrath of Radiance", "Holy", 84, 68);//20 
                        Magic heavenlySurge= new Magic("Heavenly Surge", "Holy", 106, 87);//25 
                        Magic celestialStrike= new Magic("Celestial Strike", "Holy", 183, 142);//30 
                        Magic divineIntervention= new Magic("Divine Intervention", "Holy", 500, 250);//35

                        Console.WriteLine($"'Life Bomb', it does {lifeBomb.magicDamage} damage\nIt costs {lifeBomb.magicCost} Mana\n");

                        if (Program.adventurer.Level >= 5)
                        {
                            Console.WriteLine($"'Burst of Recovery', it does {burstOfRecovery.magicDamage} damage\nIt costs {burstOfRecovery.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 10)
                        {
                            Console.WriteLine($"'Virtue of Life', it does {virtueOfLife.magicDamage} damage\nIt costs {virtueOfLife.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 15)
                        {
                            Console.WriteLine($"'Purifying Smite', it does {purifyingSmite.magicDamage} damage\nIt costs {purifyingSmite.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 20)
                        {
                            Console.WriteLine($"'Wrath of Radiance', it does {wrathOfRadiance.magicDamage} damage\nIt costs {wrathOfRadiance.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 25)
                        {
                            Console.WriteLine($"'Heavenly Surge', it does {heavenlySurge.magicDamage} damage\nIt costs {heavenlySurge.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 30)
                        {
                            Console.WriteLine($"'Celestial Strike', it does {celestialStrike.magicDamage} damage\nIt costs {celestialStrike.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 35)
                        {
                            Console.WriteLine($"'Divine Intervention', it does {divineIntervention.magicDamage} damage\nIt costs {divineIntervention.magicCost} Mana\n");
                        }
                        string spellChoice = Console.ReadLine().ToLower();
                        switch (spellChoice)
                        {
                            case "life bomb":
                                {
                                    Console.Clear();
                                    if (Program.adventurer.Mana < lifeBomb.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Life Bomb!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 101);
                                        Program.adventurer.currentMagicDamage = lifeBomb.magicDamage;
                                        Program.adventurer.currentMagicSpell = lifeBomb.magicName;
                                        Program.adventurer.currentMagicCost = lifeBomb.magicCost;
                                        Program.adventurer.currentMagicType = lifeBomb.magicType;
                                        Program.adventurer.Mana -= lifeBomb.magicCost;
                                    }
                                }
                                break;
                            case "burst of recovery":
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
                                        if (Program.adventurer.Mana < burstOfRecovery.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Burst of Recovery!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 51);
                                            Program.adventurer.currentMagicDamage = burstOfRecovery.magicDamage;
                                            Program.adventurer.currentMagicSpell = burstOfRecovery.magicName;
                                            Program.adventurer.currentMagicCost = burstOfRecovery.magicCost;
                                            Program.adventurer.currentMagicType = burstOfRecovery.magicType;
                                            Program.adventurer.Mana -= burstOfRecovery.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "virtue of life":
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
                                        if (Program.adventurer.Mana < virtueOfLife.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Virtue of Life!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                            Program.adventurer.currentMagicDamage = virtueOfLife.magicDamage;
                                            Program.adventurer.currentMagicSpell = virtueOfLife.magicName;
                                            Program.adventurer.currentMagicCost = virtueOfLife.magicCost;
                                            Program.adventurer.currentMagicType = virtueOfLife.magicType;
                                            Program.adventurer.Mana -= virtueOfLife.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "purifying smite":
                                if (Program.adventurer.Level < 15)
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
                                    if (Program.adventurer.Mana < purifyingSmite.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Purifying Smite!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = purifyingSmite.magicDamage;
                                        Program.adventurer.currentMagicSpell = purifyingSmite.magicName;
                                        Program.adventurer.currentMagicCost = purifyingSmite.magicCost;
                                        Program.adventurer.currentMagicType = purifyingSmite.magicType;
                                        Program.adventurer.Mana -= purifyingSmite.magicCost;
                                    }
                                }
                                break;
                            case "wrath of radiance":
                                if (Program.adventurer.Level < 20)
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
                                    if (Program.adventurer.Mana < wrathOfRadiance.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Wrath of Radiance!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = wrathOfRadiance.magicDamage;
                                        Program.adventurer.currentMagicSpell = wrathOfRadiance.magicName;
                                        Program.adventurer.currentMagicCost = wrathOfRadiance.magicCost;
                                        Program.adventurer.currentMagicType = wrathOfRadiance.magicType;
                                        Program.adventurer.Mana -= wrathOfRadiance.magicCost;
                                    }
                                }
                                break;
                            case "heavenly surge":
                                if (Program.adventurer.Level < 25)
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
                                    if (Program.adventurer.Mana < heavenlySurge.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Heavenly Surge!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = heavenlySurge.magicDamage;
                                        Program.adventurer.currentMagicSpell = heavenlySurge.magicName;
                                        Program.adventurer.currentMagicCost = heavenlySurge.magicCost;
                                        Program.adventurer.currentMagicType = heavenlySurge.magicType;
                                        Program.adventurer.Mana -= heavenlySurge.magicCost;
                                    }
                                }
                                break;
                            case "celestial strike":
                                if (Program.adventurer.Level < 30)
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
                                    if (Program.adventurer.Mana < celestialStrike.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Celestial Strike!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = celestialStrike.magicDamage;
                                        Program.adventurer.currentMagicSpell = celestialStrike.magicName;
                                        Program.adventurer.currentMagicCost = celestialStrike.magicCost;
                                        Program.adventurer.currentMagicType = celestialStrike.magicType;
                                        Program.adventurer.Mana -= celestialStrike.magicCost;
                                    }
                                }
                                break;
                            case "divine intervention":
                                if (Program.adventurer.Level < 35)
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
                                    if (Program.adventurer.Mana < divineIntervention.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Divine Intervention!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = divineIntervention.magicDamage;
                                        Program.adventurer.currentMagicSpell = divineIntervention.magicName;
                                        Program.adventurer.currentMagicCost = divineIntervention.magicCost;
                                        Program.adventurer.currentMagicType = divineIntervention.magicType;
                                        Program.adventurer.Mana -= divineIntervention.magicCost;
                                    }
                                }
                                break;
                            case "cancel":
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

                case "dark":
                    {
                    retry:
                        Magic necroticWave = new Magic("Necrotic Wave", "Dark", 6, 3); //1 
                        Magic taintedAura = new Magic("Tainted Aura", "Dark", 17, 9);//5 
                        Magic voidRain = new Magic("Void Rain", "Dark", 34, 13);//10 
                        Magic shadowSalvo = new Magic("Shadow Salvo", "Dark", 57, 27);//15 
                        Magic soulSiphon = new Magic("Soul Siphon", "Dark", 83, 46);//20 
                        Magic obliterationAura = new Magic("Obliteration Aura", "Dark", 152, 115);//25
                        Magic purge = new Magic("Purge", "Dark", 223, 164); //30 
                        Magic blackHole = new Magic("Black Hole", "Dark", 500, 400);//35

                        Console.WriteLine($"'Necrotic Wave', it does {necroticWave.magicDamage} damage\nIt costs {necroticWave.magicCost} Mana\n");

                        if (Program.adventurer.Level >= 5)
                        {
                            Console.WriteLine($"'Tainted Aura', it does {taintedAura.magicDamage} damage\nIt costs {taintedAura.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 10)
                        {
                            Console.WriteLine($"'Void Rain', it does {voidRain.magicDamage} damage\nIt costs {voidRain.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 15)
                        {
                            Console.WriteLine($"'Shadow Salvo', it does {shadowSalvo.magicDamage} damage\nIt costs {shadowSalvo.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 20)
                        {
                            Console.WriteLine($"'Soul Siphon', it does {soulSiphon.magicDamage} damage\nIt costs {soulSiphon.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 25)
                        {
                            Console.WriteLine($"'Obliteration Aura', it does {obliterationAura.magicDamage} damage\nIt costs {obliterationAura.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 30)
                        {
                            Console.WriteLine($"'Purge', it does {purge.magicDamage} damage\nIt costs {purge.magicCost} Mana\n");
                        }

                        if (Program.adventurer.Level >= 35)
                        {
                            Console.WriteLine($"'Black Hole', it does {blackHole.magicDamage} damage\nIt costs {blackHole.magicCost} Mana\n");
                        }
                        string spellChoice = Console.ReadLine();
                        switch (spellChoice)
                        {
                            case "necrotic wave":
                                {
                                    Console.Clear();
                                    if (Program.adventurer.Mana < necroticWave.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Necrotic Wave!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 101);
                                        Program.adventurer.currentMagicDamage = necroticWave.magicDamage;
                                        Program.adventurer.currentMagicSpell = necroticWave.magicName;
                                        Program.adventurer.currentMagicCost = necroticWave.magicCost;
                                        Program.adventurer.currentMagicType = necroticWave.magicType;
                                        Program.adventurer.Mana -= necroticWave.magicCost;
                                    }
                                }
                                break;
                            case "tainted aura":
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
                                        if (Program.adventurer.Mana < taintedAura.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Tainted Aura!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 51);
                                            Program.adventurer.currentMagicDamage = taintedAura.magicDamage;
                                            Program.adventurer.currentMagicSpell = taintedAura.magicName;
                                            Program.adventurer.currentMagicCost = taintedAura.magicCost;
                                            Program.adventurer.currentMagicType = taintedAura.magicType;
                                            Program.adventurer.Mana -= taintedAura.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "void rain":
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
                                        if (Program.adventurer.Mana < voidRain.magicCost)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You don't have enough Mana to cast this spell!");
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("You decided to use Void Rain!");
                                            Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                            Program.adventurer.currentMagicDamage = voidRain.magicDamage;
                                            Program.adventurer.currentMagicSpell = voidRain.magicName;
                                            Program.adventurer.currentMagicCost = voidRain.magicCost;
                                            Program.adventurer.currentMagicType = voidRain.magicType;
                                            Program.adventurer.Mana -= voidRain.magicCost;
                                        }
                                    }
                                }
                                break;
                            case "shadow salvo":
                                if (Program.adventurer.Level < 15)
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
                                    if (Program.adventurer.Mana < shadowSalvo.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Shadow Salvo!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = shadowSalvo.magicDamage;
                                        Program.adventurer.currentMagicSpell = shadowSalvo.magicName;
                                        Program.adventurer.currentMagicCost = shadowSalvo.magicCost;
                                        Program.adventurer.currentMagicType = shadowSalvo.magicType;
                                        Program.adventurer.Mana -= shadowSalvo.magicCost;
                                    }
                                }
                                break;
                            case "soul siphon":
                                if (Program.adventurer.Level < 20)
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
                                    if (Program.adventurer.Mana < soulSiphon.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Lightning Strike!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = soulSiphon.magicDamage;
                                        Program.adventurer.currentMagicSpell = soulSiphon.magicName;
                                        Program.adventurer.currentMagicCost = soulSiphon.magicCost;
                                        Program.adventurer.currentMagicType = soulSiphon.magicType;
                                        Program.adventurer.Mana -= soulSiphon.magicCost;
                                    }
                                }
                                break;
                            case "obliteration aura":
                                if (Program.adventurer.Level < 25)
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
                                    if (Program.adventurer.Mana < obliterationAura.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Obliteration Aura!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = obliterationAura.magicDamage;
                                        Program.adventurer.currentMagicSpell = obliterationAura.magicName;
                                        Program.adventurer.currentMagicCost = obliterationAura.magicCost;
                                        Program.adventurer.currentMagicType = obliterationAura.magicType;
                                        Program.adventurer.Mana -= obliterationAura.magicCost;
                                    }
                                }
                                break;
                            case "purge":
                                if (Program.adventurer.Level < 30)
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
                                    if (Program.adventurer.Mana < purge.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Purge!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = purge.magicDamage;
                                        Program.adventurer.currentMagicSpell = purge.magicName;
                                        Program.adventurer.currentMagicCost = purge.magicCost;
                                        Program.adventurer.currentMagicType = purge.magicType;
                                        Program.adventurer.Mana -= purge.magicCost;
                                    }
                                }
                                break;
                            case "black hole":
                                if (Program.adventurer.Level < 35)
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
                                    if (Program.adventurer.Mana < blackHole.magicCost)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You don't have enough Mana to cast this spell!");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to use Black Hole!");
                                        Program.adventurer.magicHitChance = rnd.Next(0, 41);
                                        Program.adventurer.currentMagicDamage = blackHole.magicDamage;
                                        Program.adventurer.currentMagicSpell = blackHole.magicName;
                                        Program.adventurer.currentMagicCost = blackHole.magicCost;
                                        Program.adventurer.currentMagicType = blackHole.magicType;
                                        Program.adventurer.Mana -= blackHole.magicCost;
                                    }
                                }
                                break;
                            case "cancel":
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

                case "cancel":
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
