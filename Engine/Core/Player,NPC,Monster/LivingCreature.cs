using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreature
    {
       
        private static int _currentHP;
        private static int _maxHP;
        private bool _attackable;
        private bool _dead;

        public int CurrentHP { get { return _currentHP; } set { _currentHP = value; } }
        public int MaxHP { get { return _maxHP; } set { _maxHP = value; } }
        public bool Attackable { get { return _attackable; } set { _attackable = value; } }
        public bool Dead { get { return _dead; } set { _dead = value; } }

        public LivingCreature(int currentHP, int maxHP, bool attackable, bool dead)
        {
            CurrentHP = currentHP;
            MaxHP = maxHP;
            Attackable = attackable;
            Dead = dead;
           
        }
    }
}
