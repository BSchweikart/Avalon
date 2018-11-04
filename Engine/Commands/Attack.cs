using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Attack
    {
        public static void Attacking(string noun, Player _player)
        {
            if(Player.CurrentLocation.MonsterRoom == null)
            {
                Console.WriteLine("There is nothing here to attack");
            }
            else
            {
                Combat start = new Combat();
                Monster monsterNamed;
                if(MonsterInRoom(noun, out monsterNamed))
                {

                }
            }
        }
        private static bool MonsterInRoom(string monsterName, out Monster monsterNamed)
        {
            foreach (Monster mob in Player.CurrentLocation.MonsterRoom)
            {
                //if (mob.Name.Equals(CapWord.FirstCharToUpper(monsterName)))
                //{
                //    monsterNamed = mob;
                //    return true;
                //}
            }
            monsterNamed = null;
            return false;
        }
        internal static void Attacking(string noun)
        {
            throw new NotImplementedException();
        }
    }
}
