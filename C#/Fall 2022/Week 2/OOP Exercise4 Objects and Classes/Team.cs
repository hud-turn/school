using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class_Work
{
    internal class Team
    {
        public Team(string strteamname, string strcityname, List<Players> lstplayers)//don't do uppercase parameters also public allows the for that program to be global
        {
            this.TeamName = strteamname;//this passes firstname from our program.cs file over to 
            this.CityName = strcityname;
            this.LstPlayers = lstplayers;
        }
        public string TeamName { get; set; }//get means I can read and set means I can change the value of that property
        public string CityName { get; set; } //get means that I can read the value of that property and set means that I can change the value
        public List<Players> LstPlayers { get; set;  }
        public string TeamNameReturn()
        {
            return TeamName;
        }
        public string CityNameReturn()
        {
            return CityName;
        }
    }
}