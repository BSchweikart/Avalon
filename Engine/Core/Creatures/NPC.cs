using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NPC 
    {
        //public int ID { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }


        public NPC(string name, string descrip)
        {
            //ID = id;
            Name = name;
            Descrip = descrip;
        }
    }
}
