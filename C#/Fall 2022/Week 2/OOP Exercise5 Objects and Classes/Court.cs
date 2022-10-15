using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Court
    {
        public Court(List <Score> courtscore,List<Basket> courtbasket, Ball courtball, List<Team> courtteam, Reff courtreff)
        {
            this.CourtScore = courtscore;
            this.CourtBasket = courtbasket;
            this.CourtBall = courtball;
            this.CourtTeam = courtteam;
            this.CourtReff = courtreff;
        }
        public List <Score> CourtScore { get; set; }
        public List<Basket> CourtBasket { get; set; }
        public Ball CourtBall { get; set; }
        public List <Team> CourtTeam { get; set; }
        public Reff CourtReff  { get; set; }
        public void ListAllMembers()
        {
            foreach (Team s in this.CourtTeam)
            {
                Console.WriteLine(s.TeamPlayerName + s.TeamPlayersLoc);
            }
        }
    }
}
