using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	public class Player 
	{
        private string _namePlayer;                         // To hold the player's name
        private string _classPlayer;                        // To hold the player's class
        private string _raceplayer;                         // To hold the player's race
        private int _xp;                                    // To hold the player's xp
        private int _gold;                                  // To hold the player's gold
        private int _lvl;                                   // To hold the player's level
        private int _hpCurrent;                             // To hold the player's current hit points
        private int _hpMax;                                 // To hold the playerr's max hit points
        private static Room _currentLocation;               // Not used as of yet!
        private Weapon _equipt;                             // To hold the currently equipt weapon
        private static Monster _currentMonster;
        private static NPC _currentNPC;

        public string NamePlayer { get { return _namePlayer; } set { _namePlayer = value; } }
        public string ClassPlayer { get { return _classPlayer; } set { _classPlayer = value; } }
        public string RacePlayer { get { return _raceplayer; } set { _raceplayer = value; } }
        public int Gold { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
        public int HPCurrent { get { return _hpCurrent; } set { _hpCurrent = value; } }
        public int HpMax { get { return _hpMax; } set { _hpMax = value; } }
        //public static Room CurrentLocation { get { return _currentLocation; } set { _currentLocation = value; } }
        public Weapon Equipt { get { return _equipt; } set { _equipt = value; } }
        public static Monster CurrentMonster { get { return _currentMonster; } set { _currentMonster = value; } }
        public static NPC CurrentNPC { get { return _currentNPC; } set { _currentNPC = value; } }

       
        public string Descrip { get; set; }
        public int CurrentLocation { get; set; }

        public Player(string name)
        {
            NamePlayer = name;
            //ClassPlayer = PC;
            //RacePlayer = PR;
            //Gold = gold;
            //XP = 0;
            //HPCurrent = hpCurrent;
            //HpMax = hpMax;
            //Equipt = equipt;
            CurrentLocation = 0;
        }
    }
}

