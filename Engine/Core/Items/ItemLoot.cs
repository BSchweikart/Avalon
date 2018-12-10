using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //need to add to the game
    public class ItemLoot
    {
        public Item Details { get; set; }
        
        public ItemLoot(Item details)
        {
            Details = details;
        }
    }
}
