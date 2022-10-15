using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Basket
    {
        public Basket (bool basketnum, Location loc)
        {
            this.BasketNum = basketnum;
            this.Loc = loc;
            //this.Loc2 = loc2;
            //this.Loc3 = loc3;
            //this.Loc4 = loc4;
        }
        //public List<Location> LstLocations { get; set; }
        public bool BasketNum { get; set; }
        public Location Loc { get; set; }
        //public Location Loc2 { get; set; }
        //public Location Loc3 { get; set; }
        //public Location Loc4 { get; set; }

    }
}
