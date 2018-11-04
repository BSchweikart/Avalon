using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Help
    {
        public static void HelpFile()
        {
            Console.WriteLine("Available commands");
            Console.WriteLine("------------------------------------");
            //Console.WriteLine("Stats - Display player information");
            Console.WriteLine("Look - Get the description of your location");
            Console.WriteLine("Bags - Display your inventory");
            //Console.WriteLine("Quests - Display your quests");
            Console.WriteLine("Attack - Fight the monster");
            //Console.WriteLine("Equip - Set your current weapon");
            //Console.WriteLine("Drop <item name> - Drop an item");
            Console.WriteLine("North - Move North");
            Console.WriteLine("South - Move South");
            Console.WriteLine("East - Move East");
            Console.WriteLine("West - Move West");
            Console.WriteLine("Exit - exit game");
        }
    }
}
