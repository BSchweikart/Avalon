using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Get
    {
        public static void GetCommand(string verb, Player _player)
        {
            if (string.IsNullOrEmpty(verb))
            {
                Console.WriteLine("You must enter the name of the item to get");
            }
            else
            {
                if (verb != null)
                {
                    foreach (Item item in Player.CurrentLocation.ItemRoom.ToList())
                    {
                        if (item.Name.ToLower() == verb)
                        {
                            if (item.ID > 200 && item.ID <= 300)
                            {
                                _player.Inventory.Add(new Inventory(item, 1));
                                Player.CurrentLocation.ItemRoom.Remove(item);
                            }
                            else if (item.ID > 100 && item.ID <= 200)
                            {
                                Weapon weaponToGet =
                                    WorldGenerator.weapons.SingleOrDefault(x => x.ID == item.ID);

                                _player.Inventory.Add(new Inventory(new Weapon(weaponToGet.ID, weaponToGet.Name, weaponToGet.Description, weaponToGet.Equiptable, weaponToGet.Price, weaponToGet.DamageMax), 1));
                                Player.CurrentLocation.ItemRoom.Remove(item);
                            }
                        }
                    }
                }
            }
        }
    }
}
//        public static void GetCommand(string verb, Player _player)
//        {
//            if (string.IsNullOrEmpty(verb))
//            {
//                Console.WriteLine("Enter the name of the item you want to get");

//            }
//        }

//        internal static void GetCommand(string noun)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
