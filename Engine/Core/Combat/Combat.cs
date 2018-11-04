using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Combat
    {
        private int _iterations;
        private int _attResults;
        private int _damageResults;

        public int Iterations { get { return _iterations; } set { _iterations = value; } }
        public int AttResults { get { return _attResults; } }
        public int DamageResults { get { return _damageResults; } }

        public static void Attacking(Player player, Monster monsterNamed)
        {
            //if()
            while (monsterNamed.HpCurrent > 0 && player.HpCurrent > 0)
            {
                //_attResults = attack.Roll();

                if (monsterNamed.HpCurrent > 0)
                {
                   
                }

            }
        }


    }
}
