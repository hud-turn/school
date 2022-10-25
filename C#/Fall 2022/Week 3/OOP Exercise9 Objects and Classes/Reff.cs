 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise9_Inheritance
{
    internal class Reff
    {
        public Reff(Location locreff)
        {
            this.LocReff = locreff;
        }
        public Location LocReff { get; set; }
    }
}
