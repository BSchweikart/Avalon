﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// have to look into how to populate this area with drops.

namespace Engine
{
    public class Treasure 
    {
        //public int ID { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }


        public Treasure(string name, string descrip)
        {
            //ID = id;
            Name = name;
            Descrip = descrip;
        }

    }
}
