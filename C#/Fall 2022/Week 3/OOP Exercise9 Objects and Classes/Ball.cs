using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise9_Objects_and_Classes
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
