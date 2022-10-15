using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Basket
    {
        public Basket (bool basketloc, Location loc1, Location loc2, Location loc3, Location loc4)
        {
            this.LstLocations = lstlocations;
        }
        public List<Location> LstLocations { get; set; }
    }
}
