using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	public class Player 
	{
        private int _gold;
        private int _xp;

        //public int Gold{ get { return _gold; } set { _gold = value; OnPropertyChanged("Gold"); } }
        //public int XP { get { return _xp; } set { _xp = value; OnPropertyChanged("XP"); } }
        public int Level { get; set; }
        public List<Inventory> Inventory { get; set; }
        
       
        public int CurrentLocation { get; set; }

        public Player(string name) 
        {
            //Gold = gold;
            //XP = xp;
            //Level = level;
            CurrentLocation = 0;
        }

        public void AddXP(int xpToAdd) // Used to incress player health
        {
            //XP += xpToAdd;
            //HpMax = (Level * 2); // not used until LC can take over have to fix other parts for this to happen
        }

        public void ItemAddToInventory(Item itemToAdd) // for adding items to player inventory
        {

        }
    }
}

