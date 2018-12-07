using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Potion : Item 
    {
        
        public int HealAmount { get; set; }


        public Potion(int id, string name, string description,int healAmount) : base(id, name, description, false, 0)
        {
            ID = id;
            Name = name;
            Description = description;
            HealAmount = healAmount;
        }
    }
}
