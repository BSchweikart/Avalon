﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        private int _id;
        private string _name;   //  Name
        private string _disc;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Disc { get { return _disc; } set { _disc = value; } }


        public Monster(int id, string name, string disc)
        {
            ID = id;
            Name = name;
            Disc = disc;
        }
    }
}
