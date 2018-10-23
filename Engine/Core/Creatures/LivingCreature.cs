using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature 
    {

        private int _hpCurrent;

        public int HpCurrent
        {
            get { return _hpCurrent; }
            set { _hpCurrent = value; }
        }
        
        public int HpMax { get; set; }

        public bool IsDead { get { return HpCurrent <= 0; } }

        public LivingCreature(int hpCurrent, int hpMax)
        {
            HpCurrent = hpCurrent;
            HpMax = hpMax;
        }

        //need to finish this 
       
    }
}
