using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Score
    {
        public Score (Location locscore)
        {
            this.LocScore = locscore;
        }
        public Location LocScore { get; set; }
    }
}
