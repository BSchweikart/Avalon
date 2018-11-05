using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public static class Move
    {
        public static bool canMove = true;

        public static void LocationChange(Room location)
        {
            Player.CurrentLocation = location;
        }

        public static void MoveTo(Room location)
        {
            LocationChange(location);
        }
        
        public static void LocationMoveNew(string input)         
        {
            // System.NullReferenceExeption:'Object reference not set to an instance of an object' 
            // Engine.Player.CurrentLocation.get returned null
            int ele = WorldGenerator.Location.IndexOf(Player.CurrentLocation);
            switch(input)
            {
                case "north":
                    if (Player.CurrentLocation.LocationWest != -1) 
                    {
                        LocationChange(WorldGenerator.Location[Player.CurrentLocation.LocationNorth]);
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;

                case "east": // need to finish real movment
                    if (Player.CurrentLocation.LocationEast != -1)
                    {
                        LocationChange(WorldGenerator.Location[Player.CurrentLocation.LocationEast]);
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;

                case "south":
                    if (Player.CurrentLocation.LocationSouth != -1)
                    {
                        LocationChange(WorldGenerator.Location[Player.CurrentLocation.LocationSouth]);
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;

                case "west": // need to finish real movment
                    if (Player.CurrentLocation.LocationWest != -1)
                    {
                        LocationChange(WorldGenerator.Location[Player.CurrentLocation.LocationWest]);
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;
            }
        }
    }
}
