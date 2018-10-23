using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster 
    {
        //public int Id {get; set;}
        public string Name { get; set; }
        public string Descrip { get; set; }
        //public int XpReward { get; set; }
        //public int GoldReward { get; set; }
        

        public Monster(string name, string descrip)
        {
            Name = name;
            Descrip = descrip;
        }
    }
}
