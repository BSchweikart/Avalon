using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class MovePlayer
    {
        public static void MoveTo(string verb)
        {
            Move.LocationMoveNew(verb);
            LocationCurrent.CurrentLocation();
            if (Move.canMove == false)
            {
                Console.WriteLine("You can not go " + verb);
            }
        }

    }
}
