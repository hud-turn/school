using OOP_Exercise9_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise9_Inheritance
{
    public class Team
    {
        public Team(Player teamplayers)
        {
            this.TeamPlayers = teamplayers;
        }
        public Player TeamPlayers { get; set; }
    }
}
