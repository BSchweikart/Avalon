using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {

        private int _hpCurrent;
        private int _hpMax;
        private bool _isDead;
        private bool _attackable;

        public int HpCurrent { get {return _hpCurrent; } set{_hpCurrent = value; OnPropertyChanged("HpCurrent"); } } 
        public int HpMax { get { return _hpMax; } set { _hpMax = value; } }
        public bool IsDead { get { return _isDead; } set { _isDead = value; } }
        public bool Attackable { get { return _attackable; } set { _attackable = value; } }

        public LivingCreature(int hpCurrent, int hpMax, bool isDead, bool attackable)
        {
            HpCurrent = hpCurrent;
            HpMax = hpMax;
            IsDead = IsDead;
            Attackable = attackable;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
