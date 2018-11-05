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

                if(player.HpCurrent > 0)
                {

                }

                if (monsterNamed.HpCurrent > 0)
                {
                   
                }

            }
        }


    }
}
