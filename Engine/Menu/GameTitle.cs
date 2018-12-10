using System;
using System.IO;

namespace Engine // Bring up at game load
{
    public class GameTitle 
    {
        public static void Title()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("         #                     #          ##           ########    ####        ##");
            Console.WriteLine("        ###                   ###         ##          ##  ##  ##   ## ##       ##");
            Console.WriteLine("       ## ##  ##         ##  ## ##        ##         ##   ##   ##  ##  ##      ##");
            Console.WriteLine("      ##   ##  ##       ##  ##   ##       ##        ##    ##    ## ##   ##     ##");
            Console.WriteLine("     ##     ##  ##     ##  ##     ##      ##        ############## ##    ##    ##");
            Console.WriteLine("    ###########  ##   ##  ###########     ##        ##    ##    ## ##     ##   ##");
            Console.WriteLine("   ##         ##  ## ##  ##         ##    ##         ##   ##   ##  ##      ##  ##");
            Console.WriteLine("  ##           ##  ###  ##           ##   ########### ##  ##  ##   ##       ## ##");
            Console.WriteLine(" ##             ##  #  ##             ##  ###########  ########    ##        ####");
            Console.WriteLine("_________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the world of Avalon");
            IsNewPlayer.NewPlayer();

            //Test code Almost working
            //Console.WriteLine("Enter Continue to proceed to Game Meneu");
            //Console.WriteLine("Info - This selection is not implemented as of yet");

            //string usersInput;
            //bool validAnswer = false;

            //while (validAnswer == false)
            //{
            //    Console.Write("> ");
            //    usersInput = Console.ReadLine();

            //    if (usersInput.ToLower() == "continue")
            //    {
            //        IsNewPlayer.NewPlayer();
            //    }
            //    else if (usersInput.ToLower() == "info") // Move on to create the player
            //    {
            //        //validAnswer = true;
            //        Console.WriteLine("Enter a valid answer.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter a valid answer.");
            //    }
            //}
        }
    }
}
