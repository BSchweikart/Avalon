using System;
using System.ComponentModel;
using System.Linq;
using System.IO;


namespace Engine
{
    internal class Combat
    {
        #region Properties
        public int Iteration { get; set; }
        public int AttResults { get; set; }
        public int DamageResults { get; set; }
        #endregion

        public Combat()
        {
            Iteration = 1;
        }

        public void Attacking(Monster monsterNamed, Player player)
        {
            #region. Dice Prop
            RollDie attack = new RollDie(1, 20);
            RollDie pDamage = new RollDie(player.Equipt.DamageMax);
            RollDie mDamage = new RollDie(monsterNamed.DamageMax);
            #endregion

            #region Check if Attackable
            if (monsterNamed.Attackable == false)
            {
                Console.WriteLine("Can't be attacked for whatever reason");
                return;
            }
            #endregion

            #region Attack
            while (monsterNamed.IsDead != true && player.IsDead != true)
            {
                AttResults = attack.Roll();

                Console.WriteLine("You attack with your " + player.Equipt.Name.ToString() + ": " + AttResults);

                #region player attack
                if (AttResults >= monsterNamed.Armor)
                {
                    Console.WriteLine("You hit " + monsterNamed.Name);

                    DamageResults = pDamage.Roll();
                    Console.WriteLine("You did " + DamageResults + " points of damage.");

                    monsterNamed.HpCurrent -= DamageResults;
                    Console.WriteLine(monsterNamed.Name + " has " + monsterNamed.HpCurrent + " hitpoints left");

                    #region Monster Dead
                    if (monsterNamed.HpCurrent <= 0)
                    {
                        Console.WriteLine(monsterNamed.Name + " is dead!");
                        monsterNamed.IsDead = true;
                        Console.WriteLine("The fight took " + Iteration + " rounds to finish.");
                        Player.CurrentLocation.MonsterRoom.Remove(monsterNamed);
                        player.XP += monsterNamed.XpReward;
                        player.Gold += monsterNamed.GoldReward;
                        break;
                    }
                    #endregion
                }
                else
                {
                    Console.WriteLine("You missed your attack");
                }
                #endregion
                

                #region Monster Attack
                AttResults = attack.Roll();
                Console.WriteLine(monsterNamed.Name + " attacks you: " + AttResults);

                if (AttResults > player.Armor)
                {
                    Console.WriteLine(monsterNamed.Name + " hits you!");

                    DamageResults = mDamage.Roll();
                    Console.WriteLine(monsterNamed.Name + " did " + DamageResults + " points of damage.");

                    player.HpCurrent -= DamageResults;

                    #region player dead
                    // going to add in an option to check if the player wished to tryonce more
                    if (player.HpCurrent <= 0)
                    {
                        Console.WriteLine("You are dead!");
                        player.IsDead = true;
                        Console.WriteLine("The fight took " + Iteration + " rounds to finish.\n");
                        LoadPlayer.LoadGame(player.NamePlayer);
                        //LocationCurrent.CurrentLocation();

                    }
                    #endregion
                }
                else
                {
                    Console.WriteLine(monsterNamed.Name + " Missed its attack");
                }
                #endregion

                Iteration++;
            }
            #endregion

            #region Load Contiune Menu
            if (player.IsDead == true)
            {
                //player.NamePlayer += " Dead";
                PlayerContinue.PContinue(player);
            }
            #endregion
        }
    }
}
