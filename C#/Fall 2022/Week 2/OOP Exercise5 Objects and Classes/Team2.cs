using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Team2
    {
        public Team2(string team2playername, Location team2playersloc)
        {
            this.Team2PlayerName = team2playername;
            this.Team2PlayersLoc = team2playersloc;
        }
        public string Team2PlayerName { get; set; }
        public Location Team2PlayersLoc { get; set; }
    }
}
