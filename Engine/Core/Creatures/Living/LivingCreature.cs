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
        #region Fields
        private int _hpCurrent;
        #endregion

        #region Prop
        public int HpCurrent { get {return _hpCurrent; } set{_hpCurrent = value; OnPropertyChanged("HpCurrent"); } } 
        public int HpMax { get; set; }
        public bool IsDead { get; set; }
        public bool Attackable { get; set; }
        public Faction Factions { get; set; }
        #endregion

        #region Const
        public LivingCreature(int hpCurrent, int hpMax, bool isDead, bool attackable, Faction faction)
        {
            HpCurrent = hpCurrent;
            HpMax = hpMax;
            IsDead = IsDead;
            Attackable = attackable;
            Factions = faction;
        }
        #endregion

        #region Change envent
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
