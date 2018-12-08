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
            RollDie attack = new RollDie(1, 20);
            RollDie pDamage = new RollDie(player.Equipt.DamageMax);
            while (monsterNamed.HpCurrent > 0 && player.HpCurrent > 0)
            {
                AttResults = attack.Roll();

                if(player.HpCurrent > 0 && AttResults >= 10)
                {
                    DamageResults = pDamage.Roll();
                    Console.WriteLine("You hit " + monsterNamed.Name + " for " + AttResults);
                    Console.WriteLine(monsterNamed.Name + " has " + monsterNamed.HpCurrent + " left");

                    if (monsterNamed.HpCurrent <= 0)
                    {
                        Console.WriteLine("You have defeted " + monsterNamed.Name);
                        Player.CurrentLocation.MonsterRoom.Remove(monsterNamed);
                        player.XP += monsterNamed.XpReward;
                        player.Gold += monsterNamed.GoldReward;

                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You missed your attack");
                }

                if (monsterNamed.HpCurrent > 0 && AttResults >= 10)
                {
                    Console.WriteLine(monsterNamed.Name + " hits you for " + DamageResults);
                    Console.WriteLine("You have " + player.HpCurrent + " left");

                    if (player.HpCurrent <= 0)
                    {
                        Console.WriteLine("You have been defeted ");
                        player.IsDead = true;
                      

                       
                    }
                }
                else
                {
                    Console.WriteLine(monsterNamed.Name + " Missed its attack");
                }

                Iteration++;
            }
        }
    }
}
