﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Team
    {
        public Team(bool teamaffil, string teamplayername, Location teamplayersloc,double hypotenuse)
        {
            this.TeamAffil = teamaffil; 
            this.TeamPlayerName = teamplayername;
            this.TeamPlayersLoc = teamplayersloc;
            this.Hypotenuse = hypotenuse;
        }
        public bool TeamAffil { get; set; }
        public string TeamPlayerName { get; set; }
        public Location TeamPlayersLoc { get; set; }
        public double Hypotenuse { get; set; }
    }
    
}
