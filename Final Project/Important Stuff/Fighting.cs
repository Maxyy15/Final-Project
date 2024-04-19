using Final_Project.Areas;
using Final_Project.Player_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Important_Stuff
{
    internal class Fighting
    {
        static void Fight()
        {
            string[] weaknessArr = new string[10];
            string[] resistanceArr = new string[10];
            string option;
            Random rnd1 = new Random();
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
                            Console.WriteLine("You decided to go into the forest!\nIn the forest, Goblins, Slimes and Wolves are abundent!\n\n");
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

                        option = Console.ReadLine();

                        if (option == "Look")
                        {
                            Console.Clear();
                            Console.WriteLine("You decide to look around!");
                        look:
                            if (Program.currentArea == "Forest")
                            {
                                int rn = rnd1.Next(0, 17);

                                if (rn >= 0 && rn <= 4)
                                {
                                    cm.monsterName = "Goblin";
                                    cm.monsterHealth = 20;
                                    cm.monsterDamage = 5;
                                    cm.monsterResistanceDamage = 2;
                                    cm.monsterGold = rnd.Next(4, 13);
                                    cm.monsterExp = rnd.Next(4, 10);
                                    cm.doesMonsterStatusEffect = false;
                                    cm.monsterHeal = false;
                                    resistanceArr[0] = "Water";
                                    weaknessArr[0] = "Fire";

                                }
                                else if (rn > 4 && rn <= 9)
                                {
                                    cm.monsterName = "Wolf";
                                    cm.monsterHealth = 15;
                                    cm.monsterDamage = 10;
                                    cm.monsterResistanceDamage = 3;
                                    cm.monsterGold = rnd.Next(4, 13);
                                    cm.monsterExp = rnd.Next(4, 10);
                                    cm.doesMonsterStatusEffect = false;
                                    cm.monsterHeal = false;
                                    resistanceArr[0] = "Air";
                                    weaknessArr[0] = "Water";

                                }
                                else if (rn > 9 && rn <= 14)
                                {
                                    cm.monsterName = "Slime";
                                    cm.monsterHealth = 10;
                                    cm.monsterDamage = 15;
                                    cm.monsterResistanceDamage = 2;
                                    cm.monsterGold = rnd.Next(4, 13);
                                    cm.monsterExp = rnd.Next(4, 10);
                                    cm.doesMonsterStatusEffect = false;
                                    cm.monsterHeal = false;
                                    resistanceArr[0] = "Fire";
                                    weaknessArr[0] = "Air";
                                }
                            }

                            else if (Program.currentArea == "Caves")
                            {

                                int rn = rnd1.Next(0, 16);
                                rn = 13;
                                if (rn >= 0 && rn <= 3)
                                {
                                    cm.monsterName = "Mimic";
                                    cm.monsterHealth = 40;
                                    cm.monsterDamage = 18;
                                    cm.monsterResistanceDamage = 5;
                                    cm.monsterGold = rnd.Next(20, 80);
                                    cm.monsterExp = rnd.Next(15, 40);
                                    cm.doesMonsterStatusEffect = false;
                                    cm.monsterHeal = false;
                                    resistanceArr[0] = "Water";
                                    weaknessArr[0] = "Fire";

                                }
                                else if (rn > 3 && rn <= 7)
                                {
                                    cm.monsterName = "Skeleton";
                                    cm.monsterHealth = 50;
                                    cm.monsterDamage = 14;
                                    cm.monsterResistanceDamage = 6;
                                    cm.monsterGold = rnd.Next(15, 40);
                                    cm.monsterExp = rnd.Next(30, 60);
                                    cm.doesMonsterStatusEffect = false;
                                    cm.monsterHeal = false;
                                    resistanceArr[0] = "Dark";
                                    weaknessArr[0] = "Holy";

                                }
                                else if (rn > 7 && rn <= 12)
                                {
                                    cm.monsterName = "Spider";
                                    cm.monsterHealth = 30;
                                    cm.monsterDamage = 6;
                                    cm.monsterResistanceDamage = 5;
                                    cm.monsterGold = rnd.Next(8, 18);
                                    cm.monsterExp = rnd.Next(10, 40);
                                    cm.monsterHeal = false;
                                    cm.doesMonsterStatusEffect = true;
                                    cm.monsterStatusEffect = "Poison";
                                    resistanceArr[0] = "Poison";
                                    weaknessArr[0] = "Holy";
                                }
                                else if (rn > 12 && rn <= 14)
                                {
                                    cm.monsterName = "Troll";
                                    cm.monsterHealth = 70;
                                    cm.monsterDamage = 20;
                                    cm.monsterResistanceDamage = 10;
                                    cm.monsterGold = rnd.Next(40, 80);
                                    cm.monsterExp = rnd.Next(70, 100);
                                    cm.monsterHeal = true;
                                    cm.doesMonsterStatusEffect = false;
                                    cm.monsterHealAmount = 5;
                                    resistanceArr[0] = "";
                                    weaknessArr[0] = "Fire";
                                    weaknessArr[1] = "";
                                    cm.maxMonsterHP = cm.monsterHealth;
                                }
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You found...\n\nNothing..\n");
                                goto start1;
                            }

                            Console.WriteLine($"You encountered a {cm.monsterName}!\n");
                        choice1:
                            Console.WriteLine($"Your current HP is {Program.adventurer.HP}" +
                                $"\nYour current Mana is {Program.adventurer.Mana}" +
                                $"\nYour current Damage is {Program.adventurer.currentWeaponDamage}" +
                                $"\nYour current Defense is {Program.adventurer.currentArmorProtection}\n");

                            Console.WriteLine($"The {cm.monsterName}'s HP is {cm.monsterHealth}" +
                                $"\nThe {cm.monsterName}'s Damage is {cm.monsterDamage}" +
                                $"\nThe {cm.monsterName}'s Defense is {cm.monsterResistanceDamage}\n");

                            Console.WriteLine("Do you 'Attack', 'Heal' or do you 'Escape'?");
                            option = Console.ReadLine();

                            if (option == "Attack")
                            {
                                Console.Clear();
                            tryagain:
                                Console.WriteLine("Do you attack with your 'Weapon' or your 'Magic'?");

                                option = Console.ReadLine();
                                if (option == "Weapon")
                                {
                                    if (resistanceArr.Any(resist => Program.adventurer.currentWeaponName == resist))
                                    {
                                        int damageReduction = (Program.adventurer.currentWeaponDamage / 2) - cm.monsterResistanceDamage;

                                        cm.monsterHealth -= damageReduction;

                                        Console.WriteLine($"You attacked the {cm.monsterName} for {damageReduction}!\n");
                                    }
                                    else if (weaknessArr.Any(weakness => Program.adventurer.currentWeaponName == weakness))
                                    {
                                        int damageIncrease = (Program.adventurer.currentWeaponDamage * 2) - cm.monsterResistanceDamage;

                                        cm.monsterHealth -= damageIncrease;

                                        Console.WriteLine($"You attacked the {cm.monsterName} for {damageIncrease}!\n");
                                    }
                                    else
                                    {
                                        cm.monsterHealth -= Program.adventurer.currentWeaponDamage - cm.monsterResistanceDamage;
                                        Console.WriteLine($"You attacked the {cm.monsterName} for {Program.adventurer.currentWeaponDamage - cm.monsterResistanceDamage}!\n");
                                    }
                                }
                                else if (option == "Magic")
                                {
                                    MagicSpells();
                                    if (Program.adventurer.Mana < Program.adventurer.currentMagicCost)
                                    {
                                        goto choice1;
                                    }
                                    else if (adventurer.Big == false)
                                    {
                                        Console.WriteLine("You decided not to cast a spell!\n");
                                        goto choice1;
                                    }

                                    else if (cast == false)
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
                                            int damageReduction = (Program.adventurer.currentMagicDamage / 2) - cm.monsterResistanceDamage;

                                            cm.monsterHealth -= damageReduction;

                                            Console.WriteLine($"You cast {Program.adventurer.currentMagicSpell}!\nYou hit the {cm.monsterName} for {damageReduction}!\n");
                                        }

                                        else if (weaknessArr.Any(weakness => Program.adventurer.currentMagicType == weakness))
                                        {
                                            int damageIncrease = (Program.adventurer.currentMagicDamage * 2) - cm.monsterResistanceDamage;

                                            cm.monsterHealth -= damageIncrease;

                                            Console.WriteLine($"You cast {Program.adventurer.currentMagicSpell}!\nYou hit the {cm.monsterName} for {damageIncrease}!\n");
                                        }

                                        else if (cast == true)
                                        {
                                            cm.monsterHealth -= Program.adventurer.currentMagicDamage - cm.monsterResistanceDamage;
                                            Console.WriteLine($"You cast {Program.adventurer.currentMagicSpell}!" +
                                                $"\nYou hit the {cm.monsterName} for {Program.adventurer.currentMagicDamage - cm.monsterResistanceDamage}!\n");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please enter a valid option!");
                                    goto tryagain;
                                }
                                if (cm.monsterHealth <= 0)
                                {
                                    Console.WriteLine($"You killed the {cm.monsterName}!\nYou gained {cm.monsterGold} gold!");
                                    Program.adventurer.Gold += cm.monsterGold;
                                    Program.adventurer.Exp += cm.monsterExp;
                                    cm.statusEffect = false;
                                    playerStatusCount = 0;
                                    LevelUp();

                                tryagain1:
                                    Console.WriteLine("Do you wish to fight again? 'Yes' or 'No'");
                                    option = Console.ReadLine();
                                    if (option == "Yes")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You decided to keep on fighting\n");
                                        goto look;
                                    }
                                    else if (option == "No")
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
                                    if (cm.monsterHeal == true)
                                    {
                                        if (cm.monsterHealth >= cm.maxMonsterHP)
                                        {
                                            cm.monsterHealth = cm.maxMonsterHP;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"\n{cm.monsterName} heals for {cm.monsterHealAmount}!");
                                            cm.monsterHealth += cm.monsterHealAmount;
                                        }

                                    }
                                    if (cm.statusEffect == true)
                                    {
                                        if (playerStatusCount > 0)
                                        {
                                            if (Program.adventurer.currentMagicStatus == "Stun")
                                            {
                                                if (playerStatusCount == 1)
                                                {
                                                    Console.WriteLine($"{cm.monsterName} has been stunned\nTheir turn has been skipped for {playerStatusCount} turn");
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"{cm.monsterName} has been stunned\nTheir turn has been skipped for {playerStatusCount} turns");
                                                }
                                                playerStatusCount--;
                                                goto choice1;
                                            }
                                            else if (Program.adventurer.currentMagicStatus == "Poison")
                                            {
                                                playerStatusCount--;
                                                Console.WriteLine($"{cm.monsterName} has been poisoned!\nThey will now take damage for the next ");
                                                goto choice1;
                                            }
                                        }
                                        else
                                        {
                                            cm.statusEffect = false;
                                            goto choice1;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine($"The {cm.monsterName} attacks you for {cm.monsterDamage}\n");

                                        if (cm.monsterDamage <= Program.adventurer.currentArmorProtection)
                                        {
                                            Console.WriteLine($"\nYour armor protected you from the {cm.monsterName}'s attack!");
                                            goto choice1;
                                        }
                                        else
                                        {

                                            if (Program.adventurer.currentArmorName == "God's Protection")
                                            {
                                                int leftOver2 = (int)(cm.monsterDamage - Program.adventurer.currentArmorProtection) / 2;
                                                Console.WriteLine($"Your armor protected you from {leftOver2} damage!\n");
                                                goto damage2;
                                            }

                                            else if (cm.doesMonsterStatusEffect == true)
                                            {
                                                if (cm.monsterStatusEffect == "Poison")
                                                {
                                                    int poisonChance = rnd.Next(0, 11);
                                                    if (poisonChance >= 0 && poisonChance <= 1)
                                                    {
                                                        Console.WriteLine("You have been poisoned!\n");
                                                        monstersStatusCount = 3;
                                                    }

                                                    if (monstersStatusCount != 0)
                                                    {
                                                        monstersStatusCount--;

                                                        if (monstersStatusCount == 1)
                                                        {
                                                            Console.WriteLine($"You will take 5% damage for {monstersStatusCount} last time!\n");
                                                            Program.adventurer.HP -= (int)(Program.adventurer.HP * 0.05);
                                                        }
                                                        else if (monstersStatusCount >= 1)
                                                        {
                                                            Console.WriteLine($"You will take 5% damage for {monstersStatusCount} more turns!\n");
                                                            Program.adventurer.HP -= (int)(Program.adventurer.HP * 0.05);
                                                        }
                                                        else if (monstersStatusCount == 0)
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
                                                    cm.doesMonsterStatusEffect = false;
                                                }
                                            }

                                        damage:
                                            int leftOver = cm.monsterDamage - Program.adventurer.currentArmorProtection;

                                            Program.adventurer.HP -= leftOver;
                                        damage2:
                                            if (Program.adventurer.HP <= 0)
                                            {
                                                Console.WriteLine("You're too injured to go on!\nYou lost all your gold!");
                                                Program.adventurer.Gold = 0;
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
                            else if (option == "Heal")
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
                            else if (option == "Escape")
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

                        else if (option == "Escape")
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
                while (Program.adventurer.HP >= 0 || option != "Escape");

            }
            catch (Exception e) { Console.WriteLine("game broke :( " + e); }
        }
    }
}
