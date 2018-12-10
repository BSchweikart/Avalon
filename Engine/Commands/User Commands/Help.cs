using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Help
    {
        public static void HelpFile()
        {
            Console.WriteLine("Available commands");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Stats - Display player information"); //working
            Console.WriteLine("Look - Get the description of your location"); //working
            Console.WriteLine("Bags - Display your inventory"); //Working
            //Console.WriteLine("Quests - Display your quests");
            Console.WriteLine("Attack - Fight the monster"); //working
            Console.WriteLine("Equip - Set your current weapon"); 
            Console.WriteLine("Drop - Drop an item"); //working logic error
            Console.WriteLine("North - Move North"); //working
            Console.WriteLine("South - Move South"); //working
            Console.WriteLine("East - Move East"); //working
            Console.WriteLine("West - Move West"); //working
            Console.WriteLine("Exit - exit game"); //working
        }
    }
}
