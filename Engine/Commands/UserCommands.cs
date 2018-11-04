using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class UserCommands
    {
        public static void CommandCase(string input, Player _player)
        {
            string[] commands = input.Split(null);
            string verb = commands[0].ToLower();
            string noun;
            if (commands.Length != 1)
            {
                noun = commands[1];
            }
            else
            {
                noun = "";
            }
        }

            public static void NormalCommands(string verb, string noun)
            {
                switch (verb)
                {
                    case "look":
                    
                        break;

                    case "get":
                        
                        break;

                    case "inventory":
                        
                        break;

                    case "attack":
                        
                        break;

                    case "drop":
                        
                        break;

                   
                    case "help":
                        Help.HelpFile();
                        break;
                    
                    case "north":
                        MovePlayer.MoveTo(verb);
                        break;

                    case "east":
                        MovePlayer.MoveTo(verb);
                        break;

                    case "south":
                        MovePlayer.MoveTo(verb);
                        break;

                    case "west":
                        MovePlayer.MoveTo(verb);
                        break;

                    
                }
            }
        
    }
}
