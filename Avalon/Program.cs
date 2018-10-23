using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Engine;



// Calling the menu class now have to have it work with movment
// need to fix the display so that once the game is started the same list is not shown.
// Need to add in the help/menu option to show the list's (for w/e reason)
namespace Avalon
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldListBuilder.Generate();
            GameTitle.Title();

            bool exit = false;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("You entered the " + WorldGenerator.rooms[WorldGenerator.players[0].CurrentLocation].Name);
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








