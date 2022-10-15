using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Score
    {
        public Score (bool teamindicator, int teamscore)
        {
            this.TeamIndicator = teamindicator;
            this.TeamScore = teamscore;
        }
        public Location LocScore { get; set; }
    }
}
