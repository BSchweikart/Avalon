using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	public class Player : LivingCreature
	{
        private string _namePlayer;                         // To hold the player's name
        private string _classPlayer;                        // To hold the player's class
        private string _racePlayer;                         // To hold the player's race       
        private int _currentHP;                      // To hold the player's current hit points
        private int _maxHP;                          // To hold the playerr's max hit points
        private static Room _playerLocation;

        public string NamePlayer { get { return _namePlayer; } set { _namePlayer = value; } }
        public string ClassPlayer { get { return _classPlayer; } set { _classPlayer = value; } }
        public string RacePlayer { get { return _racePlayer; } set { _racePlayer = value; } }
        public int CurrentHpPlayer { get { return _currentHP; } set { _currentHP = value; } }
        public int MaxHpPlayer { get { return _maxHP; } set { _maxHP = value; } }
        public static Room PlayerLocation { get { return _playerLocation; } set { _playerLocation = value; } }


        public Player(string name, int currentHP, int maxHP, bool attackable, bool dead) : base (currentHP, maxHP, attackable, dead)
        {
            NamePlayer = name;
            //ClassPlayer = class,
            //RacePlayer = race;
            CurrentHpPlayer = currentHP;
            MaxHpPlayer = maxHP;
            PlayerLocation = WorldGenerator.Rooms[0];
        }
    }
}

