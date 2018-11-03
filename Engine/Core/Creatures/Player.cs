using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	public class Player 
	{
        public int Gold { get; set; }
        public int XP { get; set; }
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
    }
}

