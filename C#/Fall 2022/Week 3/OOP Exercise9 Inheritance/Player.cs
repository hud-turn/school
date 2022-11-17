﻿using OOP_Exercise9_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise9_Inheritance
{
    public class Player : Employee
    {
        public Player(int teamaffil, string teamplayername, Location teamplayersloc, double hypotenuse, int gametype) : base(teamplayername, teamplayersloc, hypotenuse, teamaffil)
        {
            this.TeamAffil = teamaffil;
            this.TeamPlayerName = teamplayername;
            this.TeamPlayersLoc = teamplayersloc;
            this.Hypotenuse = hypotenuse;
            this.GameType = gametype;
        }
        public int TeamAffil { get; set; }
        public string TeamPlayerName { get; set; }
        public Location TeamPlayersLoc { get; set; }
        public double Hypotenuse { get; set; }
        public int GameType { get; set; }
    }
}
