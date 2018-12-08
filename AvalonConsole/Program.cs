using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Engine;
using System.ComponentModel;

namespace AvalonConsole
{
    public class Program  // setting up new section to house items from the main
    {

        static void Main(string[] args)
        {
            WorldListBuilder.Generate();
            GameTitle.Title();
            Console.WriteLine("");
            Weapon weapon = new Weapon(1, "dagger", "A short sword", true, 0, "10");
            Player player = new Player("Kriina", "Assassin", "Elf", 100, 0, 1, weapon, 100, 100, false, true);
            LocationCurrent.CurrentLocation();

            bool exit = false;

            do
            {
                Console.WriteLine("");
                StartMenu.LaunchMenu();  // dispaly the start menu
                Console.WriteLine(" ");
                string lowerInput = Console.ReadLine();
                Console.WriteLine(" ");
                exit = MenuList.MenuCommand(lowerInput);
            }
            while (exit == false);
        }
    }
}
//private static void ParseInput(string input)
//{
//    // Call the command class to figure out what to do.
//    UserCommands.CommandCase(input, Player._player);

//    // Write a blank line, to keep the UI a little cleaner
//    Console.WriteLine("");
//}

//while (true)
//{
//    // Wait for the user to type something, and press the <Enter> key
//    string userInput = Console.ReadLine();

//    // If they typed a blank line, loop back and wait for input again
//    if (string.IsNullOrWhiteSpace(userInput))
//    {
//        continue;
//    }

//    // Convert to lower-case, to make comparisons easier
//    string cleanedInput = userInput.ToLower();


//    if (cleanedInput == "exit")
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Saving character, will close when finished!");
//        //SaveData.SaveGameData(Player._player);
//        break;
//    }

// If the user typed something, try to determine what to do
//ParseInput(cleanedInput);




