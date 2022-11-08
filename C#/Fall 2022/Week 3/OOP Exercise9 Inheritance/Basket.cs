using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise9_Inheritance
{
    internal class Basket
    {
        public Basket (bool basketnum, Location loc)
        {
            this.BasketNum = basketnum;
            this.Loc = loc;
        }
        public bool BasketNum { get; set; }
        public Location Loc { get; set; }

    }
}
