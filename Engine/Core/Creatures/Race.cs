using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Race
    {
        public string Name { get; set; }
        public string Descrip { get; set; }
        
        public Race(string name, string descrip)
        {
            Name = name;
            Descrip = descrip;
            
        }
    }
}
