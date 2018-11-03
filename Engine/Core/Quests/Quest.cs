using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// set it up for later

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public int XpReward { get; set; }
        public int GoldReward { get; set; }
        public Item ItemReward { get; set; }

        public Quest(int id, string name, string descrip, int xpReward, int goldReward)
        {
            ID = id;
            Name = name;
            Descrip = descrip;
            XpReward = xpReward;
            GoldReward = goldReward;
        }
    }
}
