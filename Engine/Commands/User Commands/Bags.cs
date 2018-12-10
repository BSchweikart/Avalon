using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Bags
    {
        public static void BagInv(Player _player) // need to add option for treas and pots
        {
            foreach (Inventory inventory in _player.Inventory)
            {
                Console.WriteLine("{0}: {1}", inventory.WeaponName, inventory.Quantity);
            }
        }
    }
}
