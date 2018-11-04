using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Commands
{
    public static class Commands
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
                noun = " ";
            }
       
        }

        public static void NormalCommands (string verb, string noun)
        {
            switch (verb)
            {
                case "look":
                    if (noun != "")
                    {
                        Look.Looking(noun);
                    }
                    else
                    {
                        Look.Looking();
                    }
                    break;
                                    
                case "help":
                    Help.HelpInfo();
                    break;

                case "get":
                    Get.GetCommand(noun);
                    break;

                case "attack":
                    Attack.Attacking(noun);
                    break;

                case "north":
                    MovePlayer.canMove(verb);
                    break;
                case "east":
                    MovePlayer.canMove(verb);
                    break;
                case "south":
                    MovePlayer.canMove(verb);
                    break;
                case "west":
                    MovePlayer.canMove(verb);
                    break;

            }
        }
    }
}
