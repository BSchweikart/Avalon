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
                #region Text file output //out put the text files
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
                #endregion

                #region User Commands // List of user commands linked to UserCommands
                #region Movment Commands
                case "north":
                    {
                        UserCommands.MoveCommands(input);
                    }
                    return false;
                case "east":
                    {
                        UserCommands.MoveCommands(input);
                    }
                    return false;
                case "south":
                    {
                        UserCommands.MoveCommands(input);
                    }
                    return false;
                case "west":
                    {
                        UserCommands.MoveCommands(input);
                    }
                    return false;
                #endregion

                case "look":
                    {
                        UserCommands.NormalCommands(input);
                    }
                    return false;
                case "get":
                    {
                        UserCommands.NormalCommands(input);
                    }
                    return false;
                case "drop":
                    {
                        UserCommands.NormalCommands(input);
                    }
                    return false;
                case "attack":
                    {
                        UserCommands.NormalCommands(input);
                    }
                    return false;
                case "bags":
                    {
                        UserCommands.NormalCommands(input);
                    }
                    return false;
                case "use":
                    {
                        UserCommands.NormalCommands(input);
                    }
                    return false;
                case "help":
                    {
                        UserCommands.NormalCommands(input);
                    }
                    return false;
                #endregion
                case "exit":
                    return true;
                default:
                    Console.WriteLine(input + " is not a command"); // display when a command is not valid
                    return false;
            }
        }
    }
}