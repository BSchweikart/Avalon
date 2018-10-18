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
        private bool _isAttackable;
        private bool _isDead;

        public int CurrentHP { get { return _currentHP; } set { _currentHP = value; } }
        public int MaxHP { get { return _maxHP; } set { _maxHP = value; } }
        public bool IsAttackable { get { return _isAttackable; } set { _isAttackable = value; } }
        public bool IsDead { get { return _isDead; } set { _isDead = value; } }
    }
}
