using OOP_Exercise9_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise9_Inheritance
{
    internal class Ball
    {
        public Ball (Location locball)
        {
            this.LocBall = locball;
        }
        public Location LocBall { get; set; }
    }
}
