using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * Will Add more at a later date
 */


namespace Engine
{
    public class Weapon : Item
    {
        public string DamageMax { get; set; } //keep

        public Weapon(int id, string name, string description, bool equiptable, int price, string damageMax) : base (id, name, description, equiptable, price)
        {
            ID = id;
            Name = name;
            Description = description;
            Equiptable = equiptable;
            Price = price;
            DamageMax = damageMax;
        }
    }
}
