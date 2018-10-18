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
        private string _name;   //  Name
        private string _disc;
        private int _damage;
        private int _currentHP;
        private int _maxHP;
        private bool _dead;

        public int ID { get { return _id; } set { _id = value; } }
        public string NameMonster { get { return _name; } set { _name = value; } }
        public string Disc { get { return _disc; } set { _disc = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public int CurrentHPMonster { get { return _currentHP; } set { _currentHP = value; } }
        public int MaxHPMonster { get { return _maxHP; } set { _maxHP = value; } }
        public bool DeadMonster { get { return _dead; } set { _dead = value; } }


        public Monster(int id, string name, string disc, int currentHP, int maxHP, bool attackable, bool dead) : base(currentHP, maxHP, attackable, dead)
        {
            ID = id;
            NameMonster = name;
            Disc = disc;
        }
    }
}
