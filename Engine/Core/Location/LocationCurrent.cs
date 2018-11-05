using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Set up the base for location

namespace Engine
{
    public static class LocationCurrent
    {
        public static void CurrentLocation()
        {
            //Console.WriteLine("You are at: {0}", Player.CurrentLocation.NameRoom); //getting a null for location

            //if (Player.CurrentLocation.DescripRoom != "")
            //{
            //    Console.WriteLine(Player.CurrentLocation.DescripRoom);
            //}

            string exits = "\n[Exits: ";
            Console.Write("[Exits: ");
            List<string> validExits = new List<string>();

            if (Player.CurrentLocation.LocationNorth != -1)
            
                validExits.Add("north");
            
            if (Player.CurrentLocation.LocationEast != -1)
            
                validExits.Add("east");
            
            if (Player.CurrentLocation.LocationSouth != -1)
            
                validExits.Add("south");
            
            if (Player.CurrentLocation.LocationWest != -1)
            
                validExits.Add("west");
            
            if (validExits.Count == 1)
                exits += validExits[0] + " ";
            else
            {
                for (int i = 0; i < validExits.Count; i++)
                {
                    exits += validExits[i];
                    if (i < validExits.Count - 1)
                        exits += ", ";
                }
            }
        }
    }
}
