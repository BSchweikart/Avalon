﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Create_Player
{
    public static class isNewPlayer
    {
        public static void NewPlayer()
        {
            //get the user input
            string usersInput;
            //always false until user adds input
            bool validAnswer = false;

            while (validAnswer == false)
            {
                Console.WriteLine("Are you new to Avalon?");
                Console.WriteLine(">");
                usersInput = Console.ReadLine();

                if (usersInput.ToLower() == "no")
                {
                    validAnswer = true;
                    Console.WriteLine("What is your name?");
                    usersInput = CapWord.FirstCharToUpper(Console.ReadLine());
                    Load.LoadGameData(usersInput.ToLower());
                }
                else if (usersInput.ToLower() == "yes")
                {
                    validAnswer = true;
                    CreatePlayer.CreateAPlayer();
                }
                else
                {
                    Console.WriteLine("Enter a valid answer.");
                }
            }
        }
    }

}
