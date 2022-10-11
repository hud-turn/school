using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace OOP_Exercise5_Objects_and_Classes
{
    internal class Court
    {
        public Court(Score courtscore, Basket1 courtbasket1, Basket2 courtbasket2, Ball courtball, Team1 courtteam1, Team2 courtteam2, Reff courtreff)
        {
            this.CourtScore = courtscore;
            this.CourtBasket1 = courtbasket1;
            this.CourtBasket2 = courtbasket2;
            this.CourtBall = courtball;
            this.CourtTeam1 = courtteam1;
            this.CourtTeam2 = courtteam2;
            this.CourtReff = courtreff;
        }
        public Score CourtScore { get; set; }
        public Basket1 CourtBasket1 { get; set; }
        public Basket2 CourtBasket2 { get; set; }
        public Ball CourtBall { get; set; }
        public Team1 CourtTeam1 { get; set; }
        public Team2 CourtTeam2 { get; set; }
        public Reff CourtReff  { get; set; }
    }
}
