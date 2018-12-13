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
            int ele = WorldGenerator.Location.IndexOf(Player.CurrentLocation);
            switch(input)
            {
                case "north":
                    if (Player.CurrentLocation.LocationNorth != -1) 
                    {
                        LocationChange(WorldGenerator.Location[Player.CurrentLocation.LocationNorth]);
                        canMove = true;
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;

                case "east": 
                    if (Player.CurrentLocation.LocationEast != -1)
                    {
                        LocationChange(WorldGenerator.Location[Player.CurrentLocation.LocationEast]);
                        canMove = true;
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
                        canMove = true;
                    }
                    else
                    {
                        canMove = false;
                    }
                    break;

                case "west": 
                    if (Player.CurrentLocation.LocationWest != -1)
                    {
                        LocationChange(WorldGenerator.Location[Player.CurrentLocation.LocationWest]);
                        canMove = true;
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
