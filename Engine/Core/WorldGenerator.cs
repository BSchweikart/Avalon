using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/**
 * This is the area that will populate  Avalon with the items and location and others
 * room for notes at a later time
 * 
 * 
 * 
 * 
 * 
 * 
 */


namespace Engine
{ 

    public class WorldGenerator
    {
        public static List<Room> rooms = new List<Room>();
        public static List<Treasure> treasures = new List<Treasure>();
        public static List<Monster> monsters = new List<Monster>();
        public static List<Potion> potions = new List<Potion>();
        public static List<Weapon> weapons = new List<Weapon>();
        public static List<NPC> npcs = new List<NPC>();
        public static List<Player> players = new List<Player>();
        public static List<Class> classes = new List<Class>();
        public static List<Race> races = new List<Race>();


    }
}
