using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Basket
    {
        public Basket (bool basketnum, Location loc1, Location loc2, Location loc3, Location loc4)
        {
            this.BasketNum = basketnum;
            this.Loc1 = loc1;
            this.Loc2 = loc2;
            this.Loc3 = loc3;
            this.Loc4 = loc4;
        }
        public List<Location> LstLocations { get; set; }
        public bool BasketNum { get; set; }
        public Location Loc1 { get; set; }
        public Location Loc2 { get; set; }
        public Location Loc3 { get; set; }
        public Location Loc4 { get; set; }

    }
}
