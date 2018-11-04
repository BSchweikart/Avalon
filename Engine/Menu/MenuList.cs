using System;
using Engine;

namespace Engine
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
                    foreach (var obj in WorldGenerator.Location)
                    {
                        Console.WriteLine(obj.NameRoom);
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
                case "attack":
                    {
                        Console.WriteLine("Need to link in");
                        //Attack.Attacking();
                    }
                    return false;
                case "bags":
                    {
                        Console.WriteLine("Need to link in");
                    }
                    return false;
                case "use":
                    {
                        Console.WriteLine("Need to link in");
                    }
                    return false;
                case "help":
                    {
                        //Console.WriteLine("Need to make something to call");
                        Help.HelpFile();
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