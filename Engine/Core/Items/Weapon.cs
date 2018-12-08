﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** 
 * Format for weapons
 * Sprit - HP
 * STR - AP
 * Wis -  Int
 * Dex - Agi  ^forget about this redoing it^
 *
 *This might end up being to much at the start
 * ex. caster fire ball does % base of int
 * or Fire Ball damage = 168% of INT so if the mage has 100 int the FB damage would be 168 damage but then you have to add in
 * base damage so lets say base damage is 10 then it would be 10+(100*168%) would be 178 damage. This can be fixed in tuning
 *  Might look into swaping out the [MOD] for weapon damage which would allow tuning to be a little better just more math.
 */


namespace Engine
{
    public class Weapon : Item
    {
        public int Price { get; set; }
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
