using Final_Project.Areas;
using Final_Project.Monsters;
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
                            Console.WriteLine("You decided to go into the caves!\nIn the caves, Mimics, Skeletons, Spiders and Trolls are abundent!\n\n");
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
                                int rn = rnd.Next(0, 17);

                                if (rn >= 0 && rn <= 4)
                                {
                                    Goblin goblin = new Goblin("Goblin", 20, 5, rnd.Next(4, 10), rnd.Next(2,6));

                                    goblin.monsterDropName = "Goblin Teeth";
                                    Inventory.monsterDropNames.Insert(0, "Goblin Teeth");

                                    resistanceArr[0] = "Water";
                                    weaknessArr[0] = "Fire";

                                    monster = goblin;
                                }
                                else if (rn > 4 && rn <= 9)
                                {
                                    Wolf wolf = new Wolf("Wolf", 15, 10, rnd.Next(4, 10), rnd.Next(0,1));

                                    wolf.monsterDropName = "Wolf Pelt";
                                    Inventory.monsterDropNames.Insert(1, "Wolf Pelt");

                                    resistanceArr[0] = "Air";
                                    resistanceArr[1] = "";
                                    weaknessArr[0] = "Fire";

                                    monster = wolf;
                                }
                                else if (rn > 9 && rn <= 14)
                                {
                                    Slime slime = new Slime("Slime", 10, 15, rnd.Next(4, 10), rnd.Next(2,5));

                                    slime.monsterDropName = "Drops of Slime";
                                    Inventory.monsterDropNames.Insert(2, "Drops of Slime");

                                    slime.maxMonsterHP = slime.monsterHP;
                                    slime.healAmount = 3;

                                    resistanceArr[0] = "Fire";
                                    weaknessArr[0] = "Air";

                                    monster = slime;
                                }
                            }

                            else if (Program.currentArea == "cave")
                            {

                                int rn = rnd.Next(0, 16);
                                rn = 13;
                                if (rn >= 0 && rn <= 3)
                                {
                                    Mimic mimic = new Mimic("Mimic", 40, 18, rnd.Next(15, 40), rnd.Next(20, 80));
                                    
                                    resistanceArr[0] = "Water";
                                    weaknessArr[0] = "Lightning";

                                    monster = mimic;
                                }
                                else if (rn > 3 && rn <= 7)
                                {
                                    Skeleton skeleton = new Skeleton("Skeleton", 50, 14, rnd.Next(30, 60), rnd.Next(2, 6));

                                    skeleton.monsterDropName = "Bones";
                                    Inventory.monsterDropNames.Insert(3, "Bones");

                                    resistanceArr[0] = "Dark";
                                    weaknessArr[0] = "Holy";

                                    monster = skeleton;
                                }
                                else if (rn > 7 && rn <= 12)
                                {
                                    Spider spider = new Spider("Spider", 30, 6, rnd.Next(10, 40), rnd.Next(1, 3));

                                    spider.monsterDropName = "Spider Poison";
                                    Inventory.monsterDropNames.Insert(4, "Spider Poison");

                                    spider.doesStatusEffect = true;
                                    spider.statusEffectName = "Poison";

                                    resistanceArr[0] = "Poison";
                                    weaknessArr[0] = "Holy";

                                    monster = spider;
                                }
                                else if (rn > 12 && rn <= 14)
                                {
                                    Troll troll = new Troll("Troll", 70, 20, rnd.Next(70, 100), rnd.Next(0, 1));

                                    troll.monsterDropName = "Bottle of Troll Blood";
                                    Inventory.monsterDropNames.Insert(5, "Bottles of Troll Blood");

                                    troll.healAmount = 5;
                                    troll.maxMonsterHP = troll.monsterHP;

                                    resistanceArr[0] = "";
                                    weaknessArr[0] = "Fire";
                                    weaknessArr[1] = "";

                                    monster = troll;
                                }
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You found...\n\nNothing..\n");
                                goto start1;
                            }

                            Console.WriteLine($"You encountered a {monster.monsterName}!\n");
                        choice1:
                            Console.WriteLine($"Your current HP is {Program.adventurer.HP}" +
                                $"\nYour current Mana is {Program.adventurer.Mana}" +
                                $"\nYour current Damage is {Program.adventurer.currentWeaponDamage}" +
                                $"\nYour current Defense is {Program.adventurer.currentArmorProtection}\n");

                            Console.WriteLine($"The {monster.monsterName}'s HP is {monster.monsterHP}" +
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

                                if (monster.monsterHP <= 0)
                                {
                                    if (monster.monsterName == "Mimic")
                                    {

                                    }
                                    else
                                    {
                                        if (monster.monsterDrop == 0)
                                        {
                                            Console.WriteLine($"You killed the {monster.monsterName}!\nYou didn't get anything from them sadly.\n");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You killed the {monster.monsterName}!\nYou gained {monster.monsterDrop} {monster.monsterDropName}!\n");
                                            int position = Inventory.monsterDropNames.IndexOf(monster.monsterDropName);
                                            Console.WriteLine(position);
                                            Inventory.monsterDropAmount.Insert(position, +monster.monsterDrop);
                                        }
                                        //Program.adventurer.Gold += monster.monsterGold;

                                        Program.adventurer.Exp += monster.monsterExp;
                                        monster.playerStatusEffect = false;
                                        Program.playerStatusCount = 0;
                                        Level_Up.LevelUp();
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
                                                    Console.WriteLine($"{monster.monsterName} has been stunned\nTheir turn has been skipped for {Program.playerStatusCount} turn");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{monster.monsterName} has been stunned\nTheir turn has been skipped for {Program.playerStatusCount} turns");
                                                }
                                                Program.playerStatusCount--;
                                                goto choice1;
                                            }
                                            else if (Program.adventurer.currentMagicStatus == "Poison")
                                            {
                                                Program.playerStatusCount--;
                                                Console.WriteLine($"{monster.monsterName} has been poisoned!\nThey will now take damage for the next ");
                                                goto choice1;
                                            }
                                        }
                                        else
                                        {
                                            monster.playerStatusEffect = false;
                                            goto choice1;
                                        }

                                    }
                                    else
                                    {
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
                                                    int poisonChance = rnd.Next(0, 11);
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
                            Console.WriteLine("You decided to leave the forest!\n");
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
