using System;

namespace Engine
{
    public static class UserCommands
    {
        #region test things
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

            if (_player.Factions != Faction.Admin)
            {
                NormalCommands(verb, noun);
            }
            
        }
        #endregion

        public static void NormalCommands(string verb, string noun)
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

                default:
                 Console.WriteLine(verb + " is not a command"); // display when a command is not valid
                 break;
            }
        }
    }
}