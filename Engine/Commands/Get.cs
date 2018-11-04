using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Commands
{
    public class Get
    {
        public static void GetCommand(string verb, Player _player)
        {
            if (string.IsNullOrEmpty(verb))
            {
                Console.WriteLine("Enter the name of the item you want to get");
            }
        }

        internal static void GetCommand(string noun)
        {
            throw new NotImplementedException();
        }
    }
}
