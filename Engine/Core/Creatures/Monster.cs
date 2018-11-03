using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID {get; set;}
        public string Name { get; set; }
        public int DamageMax { get; set; }
        public int XpReward { get; set; }
        public int GoldReward { get; set; }
        public List<ItemLoot> LootTable { get; set; }


        public Monster(int id, string name, int damageMax, int xpReward, int goldReward, int hpCurrent, int hpMax) : base (hpCurrent, hpMax) 
        {
            ID = id;
            Name = name;
            //Descrip = descrip;
            DamageMax = damageMax;
            XpReward = xpReward;
            GoldReward = goldReward;
            LootTable = new List<ItemLoot>();

        }
    }
}
