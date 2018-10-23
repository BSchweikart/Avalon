using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	public class Player 
	{
        //public int ExperiencePoints { get; set; }
        //public int Level { get; set; }

        public string Name { get; set; }
        public string Descrip { get; set; }
        public int CurrentLocation { get; set; }

        public Player(string name, string descrip)
        {
            Name = name;
            Descrip = descrip;
            CurrentLocation = 0;
        }
    }
}

