using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        #region prop
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DamageMax { get; set; }
        public int XpReward { get; set; }
        public int GoldReward { get; set; }
        public int Armor { get; set; }
        public List<ItemLoot> LootTable { get; set; }
        #endregion

        #region Const
        public Monster(int id, string name, string description, string damageMax, int xpReward, int goldReward, int armor, int hpCurrent, int hpMax, bool isDead, bool attackable, Faction faction) : base (hpCurrent, hpMax, isDead, attackable, faction) 
        {
            ID = id;
            Name = name;
            Description = description;
            DamageMax = damageMax;
            XpReward = xpReward;
            GoldReward = goldReward;
            Armor = armor;
            HpCurrent = hpCurrent;
            HpMax = hpMax;
            IsDead = isDead;
            Attackable = attackable;
            LootTable = new List<ItemLoot>();
        }
        #endregion

        public Monster(Monster m) : base(m.HpCurrent, m.HpMax, m.IsDead, m.Attackable, m.Factions)
        {
            ID = m.ID;
            Name = m.Name;
            Description = m.Description;
            DamageMax = m.DamageMax;
            XpReward = m.XpReward;
            GoldReward = m.GoldReward;
            Armor = m.Armor;
            HpCurrent = m.HpCurrent;
            HpMax = m.HpMax;
            IsDead = m.IsDead;
            Attackable = m.Attackable;
        }
    }
}
