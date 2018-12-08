using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NPC : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }


        public NPC(int id, string name, string descrip, int hpCurrent, int hpMax, bool isDead, bool attackable, Faction faction ) : base (hpCurrent, hpMax, isDead, attackable, faction)
        {
            ID = id;
            Name = name;
            Descrip = descrip;
        }
    }
}
