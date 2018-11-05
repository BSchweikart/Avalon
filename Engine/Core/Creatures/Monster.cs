using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        private int _id;
        private string _name;
        private int _damageMax;
        private int _xpReward;
        private int _goldReward;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int DamageMax { get { return _damageMax; } set { _damageMax = value; } }
        public int XpReward { get { return _xpReward; } set { _xpReward = value; } }
        public int GoldReward { get { return _goldReward; } set { _goldReward = value; } }
        public List<ItemLoot> LootTable { get; set; }


        public Monster(int id, string name, int damageMax, int xpReward, int goldReward, int hpCurrent, int hpMax, bool isDead, bool attackable) : base (hpCurrent, hpMax, isDead, attackable) 
        {
            ID = id;
            Name = name;
            DamageMax = damageMax;
            XpReward = xpReward;
            GoldReward = goldReward;
            HpCurrent = hpCurrent;
            HpMax = hpMax;
            IsDead = isDead;
            Attackable = attackable;
            LootTable = new List<ItemLoot>();

        }
    }
}
