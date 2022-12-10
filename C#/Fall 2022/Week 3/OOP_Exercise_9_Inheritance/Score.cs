using OOP_Exercise9_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise9_Inheritance
{
    internal class Score
    {
        public Score (bool teamindicator, int teamscore)
        {
            this.TeamIndicator = teamindicator;
            this.TeamScore = teamscore;
        }
        public bool TeamIndicator { get; set; }
        public int TeamScore { get; set; }
    }
}
