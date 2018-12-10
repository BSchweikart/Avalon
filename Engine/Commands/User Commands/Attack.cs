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
            if(Player.CurrentLocation.MonsterRoom == null) // check if a monster is in the room
            {
                Console.WriteLine("There is nothing here to attack");
            }
            else
            {
                Combat start = new Combat();
                Monster monsterNamed;
                //NPC npcNamed;

                if (MonsterInRoom(noun, out monsterNamed))
                {
                    start.Attacking(monsterNamed, _player);
                }
                else
                {

                }
            }
        }

        private static bool MonsterInRoom(string monsterName, out Monster monsterNamed)
        {
            foreach (Monster mob in Player.CurrentLocation.MonsterRoom)
            {
                if (mob.Name.Equals(CapWords.FirstCharToUpper(monsterName)))
                {
                    monsterNamed = mob;
                    return true;
                }
                
            }
            monsterNamed = null;
            return false;
        }
    }
}
