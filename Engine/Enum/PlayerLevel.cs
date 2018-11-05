using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//this is not code to use something playing around with.
namespace Engine
{
    public abstract class PlayerLevel
    {
        public int Level { get; set; }
        public int XPCurrent { get; set; }
        public int XpRequired { get; set; }

        void Start()
        {
            Level = 1;
        }

        public void MonsterXP()
        {

        }
    }
}
