﻿using OOP_Exercise9_Objects_and_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise9_Inheritance
{
    internal class Team
    {
        public Team(List <Player> playerattributes)
        {
            this.PlayerAttributes = playerattributes;
        }
        public List <Player> PlayerAttributes { get; set; }
    }
}
