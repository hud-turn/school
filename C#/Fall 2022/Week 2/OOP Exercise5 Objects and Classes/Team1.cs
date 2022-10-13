using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Team1
    {
        public Team1(string team1playername, Location team1playersloc)
        {
            this.Team1PlayerName = team1playername;
            this.Team1PlayersLoc = team1playersloc;
        }
        public string Team1PlayerName { get; set; }
        public Location Team1PlayersLoc { get; set; }
    }
}
