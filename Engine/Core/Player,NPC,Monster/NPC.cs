using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NPC : LivingCreature
    {
        private int _id;
        private string _nameNPC;   //  Name
        private string _disc;

        public int ID { get { return _id; } set { _id = value; } }
        public string NameNPC { get { return _nameNPC; } set { _nameNPC = value; } }
        public string Disc { get { return _disc; } set { _disc = value; } }


        public NPC(int id, string name, string disc, int currentHP, int maxHP, bool attackable, bool dead) : base(currentHP, maxHP, attackable, dead)
        {
            ID = id;
            NameNPC = name;
            Disc = disc;
        }

        
    }
}
