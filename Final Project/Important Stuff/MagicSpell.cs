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
                        Magic solarSpike = new Magic("Solar Spike", "Fire", 200, 100); //30
                        Magic electricShower = new Magic("Electric Shower", "Fire", 150, 125); //35

                        Console.WriteLine($"'Fire Bolt', it does {fireBolt.magicDamage} damage\nIt costs {fireBolt.magicCost} Mana\nIt has a 10% chance to fail!\n");

                        if (Program.adventurer.Level >= 5)
                        {
                            Console.WriteLine($"'Lightning Strike', it does {lightningStrike.magicDamage} damage\nIt costs {lightningStrike.magicCost} Mana\nIt had a 20% chance to fail\n");
                        }
                        if (Program.adventurer.Level >= 10)
                        {
                            Console.WriteLine($"'Fire Storm', it does {fireStrom.magicDamage} damage\nIt costs {fireStrom.magicCost} Mana\nIt has a 25% chance to fail");
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
                                            Console.WriteLine("You decided to use Lightning Strike!");
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
                        Magic frostbitTorrent = new Magic("Frostbit Torrent", "Water", 25, 12); //10
                        Magic abyssalWhirl = new Magic("Abyssal Whirl", "Water", 40, 21); //15
                        Magic neptunesFury = new Magic("Neptune's Fury", "Water", 60, 34); //20
                        Magic glacierGrasp = new Magic("Glacier Grasp", "Water", 100, 50); //25
                        Magic waveOfFreezing = new Magic("Wave of Freezing", "Water", 70, 40); //30
                        Magic sirensSerenade = new Magic("Siren's Seranade", "Water", 30, 50); //35


                        Console.WriteLine($"'Ice Bolt', it does {iceBolt.magicDamage} damage\nIt costs {iceBolt.magicCost} Mana\n");
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



                        string spellChoice = Console.ReadLine().ToLower();
                        switch (spellChoice)
                        {

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
                        Magic blaseOfBlight = new Magic("Blast of Blight", "Poison", 50, 74);//25
                        Magic corrosiveFlux= new Magic("Corrosive Flux", "Poison", 84, 112); //30 
                        Magic plagueBreath= new Magic("Plague Breath", "Poison", 102, 107);//35


                        Console.WriteLine($"'Poison Strike', it does {poisonStrike.magicDamage} damage\nIt costs {poisonStrike.magicCost} Mana\n" +
                            $"It can also poison the target for 7 extra damage!\n");

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

                        string spellChoice = Console.ReadLine().ToLower();
                        switch (spellChoice)
                        {
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

                        string spellChoice = Console.ReadLine();
                        switch (spellChoice)
                        {
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
