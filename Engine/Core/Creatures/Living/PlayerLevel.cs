using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//this is not code to use something playing around with.
namespace Engine
{
    public class PlayerLevel
    {
        public int Level { get; set; }
        public int XPCurrent { get; set; }
        public int XpRequired { get { return Level * 25; } }

        void Start()
        {
            Level = 1;
        }

        public void CheckExperience(Player XP)
        {
            ExperienceToLevel(XPCurrent);
        }

        public void ExperienceToLevel(int amount)
        {
            XPCurrent += amount;
            while(XPCurrent >= XpRequired)
            {
                XPCurrent -= XpRequired;
                Level++;
            }
        }
    }
}
