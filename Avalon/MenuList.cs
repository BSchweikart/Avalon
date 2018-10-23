﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace Avalon
{
    public class MenuList
    {
        public static bool MenuCommand(string input)
        {
            switch(input.ToLower())
            {
                // need to add in the help files to clean up the menu
                //case "help":
                //    
                //    return false;
                case "classes":
                    foreach (var obj in WorldGenerator.classes)
                    {
                        Console.WriteLine(obj.Name);
                    }
                    return false;
                case "races":
                    foreach (var obj in WorldGenerator.races)
                    {
                        Console.WriteLine(obj.Name);
                    }
                    return false;
                case "monsters":
                    foreach (var obj in WorldGenerator.monsters)
                    {
                        Console.WriteLine(obj.Name);
                    }
                    return false;
                case "npc":
                    foreach (var obj in WorldGenerator.npcs)
                    {
                        Console.WriteLine(obj.Name);
                    }
                    return false;
                case "rooms":
                    foreach (var obj in WorldGenerator.rooms)
                    {
                        Console.WriteLine(obj.Name);
                    }
                    return false;
                case "weapons":
                    foreach (var obj in WorldGenerator.weapons)
                    {
                        Console.WriteLine(obj.Name);
                    }
                    return false;
                case "potions":
                    foreach (var obj in WorldGenerator.potions)
                    {
                        Console.WriteLine(obj.Name);
                    }
                    return false;
                case "treasure":
                    foreach (var obj in WorldGenerator.treasures)
                    {
                        Console.WriteLine(obj.Name);
                    }
                    return false;
                case "north":
                    if (WorldGenerator.players[0].CurrentLocation >= 20)
                    {
                        Console.WriteLine("Can't go that way!!");
                    }
                    else
                    {
                        WorldGenerator.players[0].CurrentLocation += 1;
                    }
                    return false;
                case "south":
                    if (WorldGenerator.players[0].CurrentLocation <= 0)
                    {
                        Console.WriteLine("Can't go that way!!");
                    }
                    else
                    {
                        WorldGenerator.players[0].CurrentLocation -= 1;
                    }
                    return false;
                case "exit":
                    return true;
                default:
                    Console.WriteLine("Not a command");
                    return false;
            }
        }
    }
}
                //Console.WriteLine("Help");
                //Console.WriteLine("Monsters");
                //Console.WriteLine("NPC");
                //Console.WriteLine("Races");
                //Console.WriteLine("Classes");
                //Console.WriteLine("Potions");
                //Console.WriteLine("Treasure");
                //Console.WriteLine("Weapons");
                //Console.WriteLine("Armor");
                //Console.WriteLine("Rooms");