using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //NormalCommands(verb, noun);
                //MoveCommands(verb);
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
                    Console.WriteLine("Would you look at that");
                    Look.Looking(noun);
                    break;

                    case "get":
                    //Console.WriteLine("I want that");
                    Get.GetCommand(noun, Player._player);
                    break;

                    case "bags":
                    Console.WriteLine("Going to need a bigger bag");
                    //Need to create
                    break;

                    case "attack":
                    //Console.WriteLine("You just want to push the button");
                    Attack.Attacking(noun, Player._player);
                    break;

                    case "drop":
                    Console.WriteLine("Litter bug");
                    Drop.Dropping(noun, Player._player);
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

                    default:
                        Console.WriteLine(verb + " is not a command"); // display when a command is not valid
                    break;
                }
            }
        //#region Movement Commands
        //public static void MoveCommands(string input)
        //{
        //    switch (input)
        //    {
                 
        //        //case "north":
        //        //    MovePlayer.MoveTo(input);
        //        //break;

        //        //case "east":
        //        //    MovePlayer.MoveTo(input);
        //        //break;

        //        //case "south":
        //        //    MovePlayer.MoveTo(input);
        //        //break;

        //        //case "west":
        //        //    MovePlayer.MoveTo(input);
        //        //break;

        //        //default:
        //        //    Console.WriteLine(" is not a command"); // display when a command is not valid
        //        //break;
        //    }
        //}
        //#endregion

    }
}
#region test things
//public static void CommandCase(string input, Player _player)
//{
//    string[] commands = input.Split(null);
//    string verb = commands[0].ToLower();
//    string noun;
//    if (commands.Length != 1)
//    {
//        noun = commands[1];
//        //NormalCommands(verb, noun);
//        MoveCommands(verb);
//    }
//    else
//    {
//        noun = "";
//    }
//}
#endregion