using Final_Project.Areas;
using Final_Project.Monsters;
using Final_Project.Monsters.Forest;
using Final_Project.Player_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Important_Stuff
{
    internal class Fighting
    {
        public static Monster monster = new Monster();
        public static int poisonDmg = 0;
        public static void Fight()
        {
            string[] weaknessArr = new string[10];
            string[] resistanceArr = new string[10];
            string option;

            Random rnd = new Random();
        start1:

            try
            {
                do
                {
                    if (Program.adventurer.HP <= 0)
                    {
                        Console.WriteLine("You are too injured to go on!");
                        break;
                    }
                    else
                    {
                        if (Program.currentArea == "forest")
                        {
                            Console.WriteLine("You are now deep within the forest!\n\n");
                            Console.WriteLine("Do you 'Look' around for a fight or do you 'Escape'?");
                        }
                        else if (Program.currentArea == "cave")
                        {
                            Console.WriteLine("You are now deep within the cave!\n\n");
                            Console.WriteLine("Do you 'Look' around for a fight or do you 'Escape'?");
                        }
                        else if (Program.currentArea == "desert")
                        {
                            //Manticore(Weak: Fire, Air Resist: Water, Dark) Mummy(Weak: Holy, Fire Resist:Dark, Posion)
                            //Roc(Weak: Posion, Dark Resist: Air, Earth) Purple Worm(Weak: Dark, Water  Resist: Earth, Fire, Posion)
                            //Gnoll(Weak: Earth, Holy Resist: Poison, Dark)

                            Console.WriteLine("You are now far within the desert!\n\n");
                            Console.WriteLine("Do you 'Look' around for a fight or do you 'Escape'?");
                        }
                        else if (Program.currentArea == "sea")
                        {
                            //Merfolk(Weak: Air, Dark, Posion Resist: Water, Fire) Sahuagin(Weak: Air Resist: Water, Fire)
                            //Pirate(Weak: Fire, Posion Resist: Earth, Air) Hydra(Weak: Fire Resist: Water)
                            //Harpy(Weak: Fire Resist: Air) Kraken(Weak: Air, Earth Resist: Fire, Water, Poison)

                            Console.WriteLine("You are now surrounded by nothing but the vast sea!\n\n");
                            Console.WriteLine("Do you 'Look' around for a fight or do you 'Escape'?");
                        }
                        else if (Program.currentArea == "tiamat's lair")
                        {
                            //Tiamat(Weak: Nothing Resist: Posion, Fire, Water, Air, Earth, Dark, Holy)

                            Console.WriteLine("You are now deep within the lair of Tiamat!\n\n");
                            Console.WriteLine("Do you 'Look' around for a fight or do you 'Escape'?");
                        }

                        else
                        {
                            Console.WriteLine("You broke the game somehow");
                            break;
                        }

                        option = Console.ReadLine().ToLower();

                        if (option == "look")
                        {
                            Console.Clear();
                            Console.WriteLine("You decide to look around!");
                        look:
                            if (Program.currentArea == "forest")
                            {
                                int rn = rnd.Next(0, 18);

                                if (rn >= 0 && rn <= 4)
                                {
                                    Goblin goblin = new Goblin("Goblin", 20, 5, rnd.Next(4, 10), rnd.Next(1, 4));

                                    goblin.monsterDropName = "Goblin Teeth";

                                    resistanceArr[0] = "Water";
                                    weaknessArr[0] = "Fire";
                                    weaknessArr[1] = "Poison";

                                    Learning.goblin = true;

                                    monster = goblin;
                                }
                                else if (rn > 4 && rn <= 9)
                                {
                                    Wolf wolf = new Wolf("Wolf", 15, 10, rnd.Next(4, 10), rnd.Next(0, 2));

                                    wolf.monsterDropName = "Wolf Pelt";

                                    resistanceArr[0] = "Air";
                                    resistanceArr[1] = "Earth";
                                    weaknessArr[0] = "Fire";

                                    Learning.wolf = true;

                                    monster = wolf;
                                }
                                else if (rn > 9 && rn <= 14)
                                {
                                    Slime slime = new Slime("Slime", 10, 15, rnd.Next(4, 10), rnd.Next(1, 3));

                                    slime.monsterDropName = "Drops of Slime";

                                    slime.maxMonsterHP = slime.monsterHP;
                                    slime.healAmount = 3;


                                    resistanceArr[0] = "Fire";
                                    weaknessArr[0] = "Air";

                                    Learning.slime = true;

                                    monster = slime;
                                }
                                else if (rn > 14 && rn <= 16)
                                {
                                    Ogre ogre = new Ogre("Ogre", 40, 20, rnd.Next(8, 19), rnd.Next(0, 5));

                                    ogre.monsterDropName = "Ogre Toes";

                                    resistanceArr[0] = "Water";
                                    resistanceArr[1] = "Air";
                                    weaknessArr[0] = "Fire";
                                    weaknessArr[1] = "Poison";

                                    Learning.ogre = true;

                                    monster = ogre;
                                }
                            }

                            else if (Program.currentArea == "cave")
                            {

                                int rn = rnd.Next(0, 20);

                                if (rn >= 0 && rn <= 3)
                                {
                                    Mimic mimic = new Mimic("Mimic", 40, 18, rnd.Next(15, 40), rnd.Next(20, 80));

                                    resistanceArr[0] = "Water";
                                    weaknessArr[0] = "Fire";

                                    monster = mimic;
                                }
                                else if (rn > 3 && rn <= 7)
                                {
                                    Skeleton skeleton = new Skeleton("Skeleton", 50, 14, rnd.Next(30, 60), rnd.Next(1, 3));

                                    skeleton.monsterDropName = "Bones";

                                    resistanceArr[0] = "Dark";
                                    resistanceArr[1] = "Poison";
                                    weaknessArr[0] = "Holy";

                                    monster = skeleton;
                                }
                                else if (rn > 7 && rn <= 12)
                                {
                                    Spider spider = new Spider("Spider", 30, 6, rnd.Next(10, 40), rnd.Next(1, 3));

                                    spider.monsterDropName = "Spider Poison";

                                    spider.doesStatusEffect = true;
                                    spider.statusEffectName = "Poison";

                                    resistanceArr[0] = "Poison";
                                    weaknessArr[0] = "Holy";

                                    monster = spider;
                                }
                                else if (rn > 12 && rn <= 14)
                                {
                                    Troll troll = new Troll("Troll", 70, 25, rnd.Next(70, 100), rnd.Next(0, 1));

                                    troll.monsterDropName = "Bottle of Troll Blood";

                                    troll.doesHeal = true;
                                    troll.healAmount = 5;
                                    troll.maxMonsterHP = troll.monsterHP;

                                    resistanceArr[0] = "Air";
                                    weaknessArr[0] = "Fire";
                                    weaknessArr[1] = "Poison";

                                    monster = troll;
                                }
                                else if (rn > 14 && rn <= 18)
                                {
                                    Kobold kobold = new Kobold("Kobold", 25, 15, rnd.Next(10, 40), rnd.Next(0, 2));

                                    kobold.monsterDropName = "Kobold Eyes";

                                    resistanceArr[0] = "Poison";
                                    weaknessArr[0] = "Fire";
                                    weaknessArr[1] = "Holy";

                                    monster = kobold;
                                }
                            }

                            else if (Program.currentArea == "desert")
                            {
                                int rn = rnd.Next(0, 20);

                                if (rn >= 0 && rn <= 3)
                                {
                                    Manticore manticore = new Manticore("Manticore", 80, 35, rnd.Next(40, 100), rnd.Next(0, 2));

                                    manticore.monsterDropName = "Manticore Stringer";

                                    manticore.doesStatusEffect = true;
                                    manticore.statusEffectName = "Poison";

                                    resistanceArr[0] = "Water";
                                    resistanceArr[1] = "Dark";
                                    weaknessArr[0] = "Fire";
                                    weaknessArr[1] = "Air";

                                    monster = manticore;
                                }
                                else if (rn > 3 && rn <= 7)
                                {
                                    Mummy mummy = new Mummy("Mummy", 60, 45, rnd.Next(20, 80), rnd.Next(1, 3));

                                    mummy.monsterDropName = "Sheets of Linen";

                                    resistanceArr[0] = "Poison";
                                    resistanceArr[1] = "Dark";
                                    weaknessArr[0] = "Fire";
                                    weaknessArr[1] = "Holy";

                                    monster = mummy;
                                }
                                else if (rn > 7 && rn <= 12)
                                {
                                    Roc roc = new Roc("Roc", 60, 30, rnd.Next(20, 60), rnd.Next(1, 4));

                                    roc.monsterDropName = "Roc Feathers";

                                    resistanceArr[0] = "Air";
                                    resistanceArr[1] = "Earth";
                                    weaknessArr[0] = "Poison";
                                    weaknessArr[1] = "Dark";
                                    
                                    monster = roc;
                                }
                                else if (rn > 12 && rn <= 14)
                                {
                                    Purple_Worm purpleWorm = new Purple_Worm("Purple Worm", 120, 25, rnd.Next(50, 120), rnd.Next(0, 3));

                                    purpleWorm.monsterDropName = "Purple Worm Eggs";

                                    resistanceArr[0] = "Fire";
                                    resistanceArr[1] = "Earth";
                                    resistanceArr[2] = "Poison";
                                    weaknessArr[0] = "Dark";
                                    weaknessArr[1] = "Water";

                                    monster = purpleWorm;
                                }
                                else if (rn > 14 && rn <= 18)
                                {
                                    Gnoll gnoll = new Gnoll("Gnoll", 55, 45, rnd.Next(20, 50), rnd.Next(2, 5));

                                    gnoll.monsterDropName = "Gnoll Hide";

                                    resistanceArr[0] = "Poison";
                                    resistanceArr[1] = "Dark";
                                    weaknessArr[0] = "Earth";
                                    weaknessArr[1] = "Holy";

                                    monster = gnoll;
                                }
                            }

                            else if (Program.currentArea == "sea")
                            {
                                int rn = rnd.Next(0, 22);

                                if (rn >= 0 && rn <= 3)
                                {
                                    Merfolk merfolk = new Merfolk("Merfolk", 150, 60, rnd.Next(90, 180), rnd.Next(0, 2));

                                    merfolk.monsterDropName = "Merfolk Tail";

                                    resistanceArr[0] = "Water";
                                    resistanceArr[1] = "Fire";
                                    weaknessArr[0] = "Dark";
                                    weaknessArr[1] = "Air";
                                    weaknessArr[2] = "Poison";

                                    monster = merfolk;
                                }
                                else if (rn > 3 && rn <= 7)
                                {
                                    Sahuagin sahuagin = new Sahuagin("Sahuagin", 180, 55, rnd.Next(120, 200), rnd.Next(1, 3));

                                    sahuagin.monsterDropName = "Sahuagin Fins";

                                    resistanceArr[0] = "Water";
                                    resistanceArr[1] = "Fire";
                                    resistanceArr[2] = "Poison";
                                    weaknessArr[0] = "Air";
                                    weaknessArr[1] = "Holy";
                                    weaknessArr[2] = "Earth";

                                    monster = sahuagin;
                                }
                                else if (rn > 7 && rn <= 12)
                                {
                                    Pirate pirate = new Pirate("Pirate", 150, 60, rnd.Next(100, 170), rnd.Next(100, 400));

                                    resistanceArr[0] = "Air";
                                    resistanceArr[1] = "Earth";
                                    resistanceArr[2] = "Water";
                                    weaknessArr[0] = "Poison";
                                    weaknessArr[1] = "Fire";

                                    monster = pirate;
                                }
                                else if (rn > 12 && rn <= 14)
                                {
                                    Hydra hydra = new Hydra("Hydra", 200, 50, rnd.Next(80, 200), rnd.Next(0, 3));

                                    hydra.monsterDropName = "Hydra Head";

                                    hydra.maxMonsterHP = 200;
                                    hydra.healAmount = 20;
                                    hydra.doesHeal = true;


                                    resistanceArr[0] = "Water";
                                    resistanceArr[1] = "Poison";
                                    resistanceArr[2] = "Dark";
                                    weaknessArr[0] = "Fire";
                                    weaknessArr[1] = "Earth";

                                    monster = hydra;
                                }
                                else if (rn > 14 && rn <= 18)
                                {
                                    Harpy harpy = new Harpy("Harpy", 120, 70, rnd.Next(70, 160), rnd.Next(2, 5));

                                    harpy.monsterDropName = "Harpy Feathers";

                                    resistanceArr[0] = "Air";
                                    weaknessArr[0] = "Fire";

                                    monster = harpy;
                                }
                                else if (rn > 18 && rn <= 20)
                                {
                                    Kraken kraken = new Kraken("Kraken", 300, 40, rnd.Next(100, 250), rnd.Next(1, 4));

                                    kraken.monsterDropName = "Kraken Tenticles";

                                    resistanceArr[0] = "Poison";
                                    resistanceArr[1] = "Water";
                                    resistanceArr[2] = "Fire";
                                    weaknessArr[0] = "Earth";
                                    weaknessArr[1] = "Air";

                                    monster = kraken;
                                }

                            }

                            else if (Program.currentArea == "tiamat's lair")
                            {
                                Tiamat tiamat = new Tiamat("Tiamat", 1000, 500);

                                monster.doesHeal = true;
                                monster.healAmount = 50;

                                monster.doesStatusEffect = true;


                                resistanceArr[0] = "Fire";
                                resistanceArr[1] = "Water";
                                resistanceArr[2] = "Earth";
                                resistanceArr[3] = "Poison";
                                resistanceArr[4] = "Air";
                                resistanceArr[5] = "Dark";
                                weaknessArr[0] = "Holy";

                                monster = tiamat;
                            }
                        

                            else if (monster == null)
                            {
                                Console.Clear();
                                Console.WriteLine("You found...\n\nNothing..\n");
                                goto look;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You found...\n\nNothing..\n");
                                goto look;
                            }
                            Console.WriteLine($"You encountered a {monster.monsterName}!\n");
                        choice1:
                            Console.Write($"Your current ");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write("HP "); Console.ResetColor();
                            Console.Write("is");
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write($" {Program.adventurer.HP}"); Console.ResetColor();

                            Console.Write($"\nYour current ");
                            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Mana"); Console.ResetColor();
                            Console.Write(" is ");
                            Console.ForegroundColor = ConsoleColor.Blue; Console.Write($" {Program.adventurer.Mana}"); Console.ResetColor();

                            Console.Write($"\nYour current");
                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(" Damage "); Console.ResetColor();
                            Console.Write("is");
                            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write($" {Program.adventurer.currentWeaponDamage}"); Console.ResetColor();

                            Console.Write($"\nYour current");
                            Console.ForegroundColor = ConsoleColor.Gray; Console.Write(" Defense "); Console.ResetColor();
                            Console.Write("is");
                            Console.ForegroundColor = ConsoleColor.Gray; Console.Write($" {Program.adventurer.currentArmorProtection}\n"); Console.ResetColor();


                            Console.WriteLine($"\n\nThe {monster.monsterName}'s HP is {monster.monsterHP}" +
                                $"\nThe {monster.monsterName}'s Damage is {monster.monsterDamage}");
                            //$"\nThe {monster.monsterName}'s Defense is {monster.monsterResistanceDamage}\n");

                            Console.WriteLine("Do you 'Attack', 'Heal' or do you 'Escape'?");
                            option = Console.ReadLine().ToLower();

                            if (option == "attack")
                            {
                                Console.Clear();
                            tryagain:
                                Console.WriteLine("Do you attack with your 'Weapon' or your 'Magic'?");

                                option = Console.ReadLine().ToLower();
                                if (option == "weapon")
                                {
                                    if (resistanceArr.Any(resist => Program.adventurer.currentWeaponName == resist))
                                    {
                                        int damageReduction = (Program.adventurer.currentWeaponDamage / 2);

                                        monster.monsterHP -= damageReduction;

                                        Console.WriteLine($"You attacked the {monster.monsterName} for {damageReduction}!\n");
                                    }
                                    else if (weaknessArr.Any(weakness => Program.adventurer.currentWeaponName == weakness))
                                    {
                                        int damageIncrease = (Program.adventurer.currentWeaponDamage * 2);

                                        monster.monsterHP -= damageIncrease;

                                        Console.WriteLine($"You attacked the {monster.monsterName} for {damageIncrease}!\n");
                                    }
                                    else
                                    {
                                        monster.monsterHP -= Program.adventurer.currentWeaponDamage;
                                        Console.WriteLine($"You attacked the {monster.monsterName} for {Program.adventurer.currentWeaponDamage}!\n");
                                    }
                                }
                                else if (option == "magic")
                                {
                                    MagicSpell.MagicSpells();
                                    if (Program.adventurer.Mana < Program.adventurer.currentMagicCost)
                                    {
                                        goto choice1;
                                    }
                                    else if (Program.adventurer.Big == false)
                                    {
                                        Console.WriteLine("You decided not to cast a spell!\n");
                                        goto choice1;
                                    }

                                    else if (Program.cast == false)
                                    {
                                        Program.adventurer.currentMagicDamage = 0;
                                        Program.adventurer.currentMagicSpell = "";
                                        Program.adventurer.currentMagicType = "";
                                        Program.adventurer.currentMagicCost = 0;
                                        goto choice1;
                                    }
                                    else
                                    {
                                        if (resistanceArr.Any(resist => Program.adventurer.currentMagicType == resist))
                                        {
                                            int damageReduction = (Program.adventurer.currentMagicDamage / 2);

                                            monster.monsterHP -= damageReduction;

                                            Console.WriteLine($"You cast {Program.adventurer.currentMagicSpell}!\nYou hit the {monster.monsterName} for {damageReduction}!\n");
                                        }

                                        else if (weaknessArr.Any(weakness => Program.adventurer.currentMagicType == weakness))
                                        {
                                            int damageIncrease = (Program.adventurer.currentMagicDamage * 2);

                                            monster.monsterHP -= damageIncrease;

                                            Console.WriteLine($"You cast {Program.adventurer.currentMagicSpell}!\nYou hit the {monster.monsterName} for {damageIncrease}!\n");
                                        }

                                        else if (Program.cast == true)
                                        {
                                            monster.monsterHP -= Program.adventurer.currentMagicDamage;
                                            Console.WriteLine($"You cast {Program.adventurer.currentMagicSpell}!" +
                                                $"\nYou hit the {monster.monsterName} for {Program.adventurer.currentMagicDamage}!\n");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please enter a valid option!");
                                    goto tryagain;
                                }

                            death:
                                if (monster.monsterHP <= 0)
                                {
                                    if (monster.monsterName == "Mimic")
                                    {
                                        Console.WriteLine($"You killed the {monster.monsterName}!\nYou gained ");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write($"{monster.monsterGold} gold");
                                        Console.ResetColor();
                                        Console.Write("!");

                                        Program.adventurer.Gold += monster.monsterGold;
                                    }
                                    else if(monster.monsterName == "Pirate")
                                    {
                                        Console.WriteLine($"You killed the {monster.monsterName}!\nYou gained ");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write($"{monster.monsterGold} gold");
                                        Console.ResetColor();
                                        Console.Write("!");

                                        Program.adventurer.Gold += monster.monsterGold;
                                    }
                                    else if (monster.monsterName == "Tiamat")
                                    {
                                        Console.WriteLine("You have slain Tiamat, the God of the Evil Dragons!\nYou have saved the world from eternal darkness!");
                                        Game.Finish();
                                    }
                                    else
                                    {
                                        if (monster.monsterDrop == 0)
                                        {
                                            Console.WriteLine($"You killed the {monster.monsterName}!\nYou didn't get any drops from them sadly.\nYou gained {monster.monsterExp} exp!\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You killed the {monster.monsterName}!\nYou gained {monster.monsterDrop} {monster.monsterDropName}!" +
                                                $"\nYou also gained {monster.monsterExp} exp!\n");
                                        }

                                        int position = Inventory.monsterDropNames.IndexOf(monster.monsterDropName);
                                        //Console.WriteLine(position);
                                        Inventory.monsterDropAmount[position] += monster.monsterDrop;
                                    }

                                    Program.adventurer.Exp += monster.monsterExp;
                                    monster.playerStatusEffect = false;
                                    Program.playerStatusCount = 0;
                                    Level_Up.LevelUp();

                                    monster = null;

                                    for (int i = 0; i >= 10; i++)
                                    {
                                        resistanceArr[i] = "";
                                        weaknessArr[i] = "";
                                    }


                                tryagain1:
                                    Console.WriteLine("Do you wish to fight again? 'Yes' or 'No'");
                                    option = Console.ReadLine().ToLower();
                                    if (option == "yes")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to keep on fighting\n");
                                        goto look;
                                    }
                                    else if (option == "no")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to leave!\n");
                                        Game.Transition<Menu>();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please enter a valid option!");
                                        goto tryagain1;
                                    }
                                }
                                else
                                {
                                    if (monster.doesHeal == true)
                                    {
                                        if (monster.monsterHP >= monster.maxMonsterHP)
                                        {
                                            monster.monsterHP = monster.maxMonsterHP;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"\n{monster.monsterName} heals for {monster.healAmount}!");
                                            monster.monsterHP += monster.healAmount;
                                        }

                                    }
                                    if (monster.playerStatusEffect == true)
                                    {
                                        if (Program.playerStatusCount > 0)
                                        {
                                            if (Program.adventurer.currentMagicStatus == "Stun")
                                            {
                                                if (Program.playerStatusCount == 1)
                                                {
                                                    Console.WriteLine($"\n{monster.monsterName} has been stunned\nTheir turn has been skipped for {Program.playerStatusCount} turn\n");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"\n{monster.monsterName} has been stunned\nTheir turn has been skipped for {Program.playerStatusCount} turns\n");
                                                }
                                                Program.playerStatusCount--;
                                                goto choice1;
                                            }
                                            else if (Program.adventurer.currentMagicStatus == "Poison")
                                            {
                                                if(resistanceArr.Any(resist => Program.adventurer.currentMagicStatus == resist))
                                                {
                                                    int poisonResist = poisonDmg / 2;
                                                    if (Program.playerStatusCount == 1)
                                                    {
                                                        Console.WriteLine($"\n{monster.monsterName} has been poisoned!\nThey will now take {poisonResist} extra damage for one last turn\n");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"\n{monster.monsterName} has been poisoned!\nThey will now take {poisonResist} extra damage for the next {Program.playerStatusCount} turns\n");
                                                    }
                                                    monster.monsterHP -= poisonResist;
                                                    Program.playerStatusCount--;
                                                }

                                                else if (weaknessArr.Any(weakness => Program.adventurer.currentMagicStatus == weakness))
                                                {
                                                    int poisonWeakness = poisonDmg * 2;
                                                    if (Program.playerStatusCount == 1)
                                                    {
                                                        Console.WriteLine($"{monster.monsterName} has been poisoned!\nThey will now take {poisonWeakness} extra damage for one last turn");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{monster.monsterName} has been poisoned!\nThey will now take {poisonWeakness} extra damage for the next {Program.playerStatusCount} turns");
                                                    }
                                                    monster.monsterHP -= poisonWeakness;
                                                    Program.playerStatusCount--;
                                                }

                                                else
                                                {
                                                    if (Program.playerStatusCount == 1)
                                                    {
                                                        Console.WriteLine($"{monster.monsterName} has been poisoned!\nThey will now take {poisonDmg} extra damage for one last turn");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"{monster.monsterName} has been poisoned!\nThey will now take {poisonDmg} extra damage for the next {Program.playerStatusCount} turns");
                                                    }
                                                    monster.monsterHP -= poisonDmg;
                                                    Program.playerStatusCount--;
                                                }

                                                if (monster.monsterHP <= 0)
                                                {
                                                    goto death;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            monster.playerStatusEffect = false;
                                            goto choice1;
                                        }

                                    }

                                    Console.WriteLine($"The {monster.monsterName} attacks you for {monster.monsterDamage}\n");

                                    if (monster.monsterDamage <= Program.adventurer.currentArmorProtection)
                                    {
                                        Console.WriteLine($"\nYour armor protected you from the {monster.monsterName}'s attack!");
                                        goto choice1;
                                    }
                                    else
                                    {

                                        if (Program.adventurer.currentArmorName == "God's Protection")
                                        {
                                            int leftOver2 = (int)(monster.monsterDamage - Program.adventurer.currentArmorProtection) / 2;
                                            Console.WriteLine($"Your armor protected you from {leftOver2} damage!\n");
                                            goto damage2;
                                        }

                                        else if (monster.doesStatusEffect == true)
                                        {
                                            if (monster.statusEffectName == "Poison")
                                            {
                                                int poisonChance = 0;
                                                if (monster.monsterName == "Spider")
                                                {
                                                    poisonChance = rnd.Next(0, 11);
                                                }
                                                else if (monster.monsterName == "Manticore")
                                                {
                                                    poisonChance = rnd.Next(0, 6);
                                                }
                                                
                                                if (poisonChance >= 0 && poisonChance <= 1)
                                                {
                                                    Console.WriteLine("You have been poisoned!\n");
                                                    Program.monstersStatusCount = 3;
                                                }

                                                if (Program.monstersStatusCount != 0)
                                                {
                                                    Program.monstersStatusCount--;

                                                    if (Program.monstersStatusCount == 1)
                                                    {
                                                        Console.WriteLine($"You will take 5% damage for {Program.monstersStatusCount} last time!\n");
                                                        Program.adventurer.HP -= (int)(Program.adventurer.HP * 0.05);
                                                    }
                                                    else if (Program.monstersStatusCount >= 1)
                                                    {
                                                        Console.WriteLine($"You will take 5% damage for {Program.monstersStatusCount} more turns!\n");
                                                        Program.adventurer.HP -= (int)(Program.adventurer.HP * 0.05);
                                                    }
                                                    else if (Program.monstersStatusCount == 0)
                                                    {
                                                        Console.WriteLine("You are no longer poisoned!\n");
                                                    }
                                                }
                                                else
                                                {
                                                    goto damage;
                                                }
                                            }
                                            else
                                            {
                                                monster.doesStatusEffect = false;
                                            }
                                        }

                                    damage:
                                        int leftOver = monster.monsterDamage - Program.adventurer.currentArmorProtection;

                                        Program.adventurer.HP -= leftOver;
                                    damage2:
                                        if (Program.adventurer.HP <= 0)
                                        {
                                            Console.WriteLine("You died.");
                                            Program.die = true;
                                            Game.Finish();
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                        }
                                        else
                                        {
                                            goto choice1;
                                        }
                                    }

                                }
                            }
                            else if (option == "heal")
                            {
                                Magic heal = new Magic("Heal", "Holy", 20, 10);

                                if (Program.adventurer.HP == 100)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You're already at maximum health!");
                                    goto choice1;
                                }

                                else if (Program.adventurer.Mana < heal.magicCost)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You don't have enough Mana to cast this spell!");
                                    goto choice1;
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("You decided to heal!");
                                    Program.adventurer.HP += heal.magicDamage;
                                    Program.adventurer.Mana -= heal.magicCost;

                                    if (Program.adventurer.HP > 100)
                                    {
                                        Program.adventurer.HP = 100;
                                    }
                                    goto choice1;
                                }
                            }
                            else if (option == "escape")
                            {
                                Console.Clear();
                                Console.WriteLine("You decided to run away!");
                                Game.Transition<Menu>();
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Enter a valid option!");
                                goto choice1;
                            }
                        }

                        else if (option == "escape")
                        {
                            Console.Clear();
                            Console.WriteLine("You decided to leave!\n");
                            Game.Transition<Menu>();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter valid option!\n");
                            goto start1;
                        }
                    }
                }
                while (Program.adventurer.HP >= 0 || option != "escape");

            }
            catch (Exception e) { Console.WriteLine("game broke :( " + e); }
        }
    }
}
//Console.WriteLine($"Your current ");
//Console.ForegroundColor = ConsoleColor.Red; Console.Write("HP"); Console.ResetColor();
//Console.Write("is");
//Console.ForegroundColor = ConsoleColor.Red; Console.Write("{Program.adventurer.HP}"); Console.ResetColor();

//Console.Write($"\nYour current ");
//Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Mana"); Console.ResetColor();
//Console.Write(" is ");
//Console.ForegroundColor = ConsoleColor.Blue; Console.Write($"{Program.adventurer.Mana}"); Console.ResetColor();

//Console.Write($"\nYour current");
//Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(" Damage "); Console.ResetColor();
//Console.Write("is");
//Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write($" {Program.adventurer.currentWeaponDamage}"); Console.ResetColor();

//Console.Write($"\nYour current");
//Console.ForegroundColor = ConsoleColor.Gray; Console.Write(" Defense "); Console.ResetColor();
//Console.Write("is");
//Console.ForegroundColor = ConsoleColor.Gray; Console.Write($"{Program.adventurer.currentArmorProtection}\n"); Console.ResetColor();