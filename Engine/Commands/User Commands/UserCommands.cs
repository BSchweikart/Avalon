using System;

namespace Engine
{
    public static class UserCommands
    {
        #region Set Faction
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

            if (_player.Factions != Faction.Dev) //Not used at this time
            {
                NormalCommands(verb, noun);
            }
            
        }
        #endregion

        public static void NormalCommands(string verb, string noun)
        {
            switch (verb)
            {
                #region Gen Input
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
                
                case "get":
                 Get.GetCommand(noun, Player._player);
                 break;
                
                case "bags":
                 Bags.BagInv(Player._player);
                 break;
                
                case "attack":
                 Attack.Attacking(noun, Player._player);
                 break;
                
                case "drop":
                 Drop.Dropping(noun, Player._player);
                 break;
                
                case "help":
                    Help.HelpFile();
                    break;
                
                case "stats":
                    Stats.info(Player._player);
                    break;

                case "equip":
                    Equipt.Equip(noun, Player._player);
                    break;
                #endregion

                #region Movemnt Input
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
                #endregion

                case "devmenu": // Hidden Option to bring up options to display Files
                    DevMenu.InterMenu();
                    break;

                default:
                    Console.WriteLine(verb + " is not a command"); // display when a command is not valid
                    break;
            }
        }
    }
}