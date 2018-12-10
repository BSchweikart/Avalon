using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Parent Class for all Items
    public class Item
    {                
        public int ID { get; set;}
        public string Name { get; set;}
        public string Description { get; set;}
        public bool Equiptable { get; set; }
        public int Price { get; set; }
       

        public Item(int id, string name, string description, bool equiptable, int price)
        {
            ID = id;
            Name = name;
            Description = description;
            Equiptable = equiptable;
            Price = price;
        }
    }
}
