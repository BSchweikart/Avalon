using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Class
    {
        public string Name { get; set; }
        public string Descrip { get; set; }

        public Class(string name, string descrip)
        {
            Name = name;
            Descrip = descrip;

        }
    }
}
