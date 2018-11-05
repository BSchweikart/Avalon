using System;
using System.ComponentModel;
using System.Linq;
using System.IO;


namespace Engine
{
    internal class Combat
    {
        private int _iteration;
        private int _attResults;
        private int _damageResults;

        public int Iteration { get { return _iteration; } set { _iteration = value; } }
        public int AttResults { get { return _attResults; } }
        public int DamageResults { get { return _damageResults; } }

        public Combat()
        {
            Iteration = 1;
        }

        public void Attacking(Player player, Monster monsterNamed)
        {
            //if()
            while (monsterNamed.HpCurrent > 0 && player.HpCurrent > 0)
            {
                //_attResults = attack.Roll();

                if(player.HpCurrent > 0 && AttResults >= 10)
                {
                    Console.WriteLine("You hit " + monsterNamed.Name + " for " + DamageResults);
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
