using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        private string _namePlayer;                         // To hold the player's name
        private string _classPlayer;                        // To hold the player's class
        private string _racePlayer;
        private int _gold;
        private int _xp;
        private int _level;
        private static Room _currentLocation;

        public static Player _player;
        public string NamePlayer { get { return _namePlayer; } set { _namePlayer = value; } }
        public string ClassPlayer { get { return _classPlayer; } set { _classPlayer = value; } }
        public string RacePlayer { get{return _racePlayer;} set { _racePlayer = value; } }
        public int Gold{ get { return _gold; } set { _gold = value; OnPropertyChanged("Gold"); } }
        public int XP { get { return _xp; } set { _xp = value; OnPropertyChanged("XP"); } }
        public int Level { get {return _level; } set {_level = value; OnPropertyChanged("Level"); } }
        public List<Inventory> Inventory { get; set; }
        public static Room CurrentLocation { get {return _currentLocation; } set { _currentLocation = value; } }
        

        public Item Equipt { get; internal set; }

        //public Room CurrentLocation { get { return _currentLocation; } set { _currentLocation = value; } }

        public Player(string namePlayer, string classPlayer, string racePlayer, int gold, int xp, int level, Weapon equipt, int hpCurrent, int hpMax, bool isDead, bool attackable) : base (hpCurrent, hpMax, isDead, attackable)
        {
            NamePlayer = namePlayer;
            ClassPlayer = classPlayer;
            RacePlayer = RacePlayer;
            Gold = gold;
            XP = 0;
            Level = level;
            CurrentLocation = WorldGenerator.Location[0];            
            //Engine.Player.CurrentLocation.get returned null
        }

        //public Player(string playerName, string pC, string pR, int gold, int currentHitPoints, int maximumHitPoints, Weapon equipt, bool v1, bool v2, int alignment)
        //{
        //    Gold = gold;
        //}

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

