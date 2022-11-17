using OOP_Exercise9_Inheritance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace OOP_Exercise9_Inheritance
{
    internal class Court
    {
        public Court(List <Score> courtscore,List<Basket> courtbasket, Ball courtball, List<Player> courtteam, Reff courtreff)
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
        public List <Player> CourtTeam { get; set; }
        public Reff CourtReff  { get; set; }

        public void ListAllMembers()
        {
            foreach (Player s in this.CourtTeam)
            {
                Console.WriteLine(s.TeamPlayerName + " " + s.TeamPlayersLoc.X + " " + s.TeamPlayersLoc.Y);
            }
        }
        public void ClosestToReff()
        {
            
            foreach (Player b in this.CourtTeam)
            {
                double x = this.CourtReff.LocReff.X;
                double y = this.CourtReff.LocReff.Y;
                double xdiff = b.TeamPlayersLoc.X - x;
                double ydiff = b.TeamPlayersLoc.Y - y;
                double hypo = (ydiff * ydiff) + (xdiff * xdiff);
                double hypotenuse = Math.Sqrt(hypo);
                b.Hypotenuse = hypotenuse;
                Console.WriteLine(b.TeamPlayerName + " " + Math.Round(b.Hypotenuse, 2));
            }
            //Console.WriteLine(CourtTeam.OrderBy(x => x.Hypotenuse).ToList());

        }
        public string Scored()
        {
            foreach (Score a in this.CourtScore)
            {
                if(a.TeamScore > 0)
                {
                    return "A basket has been scored";
                }
            }
            return "A basket has not been scored";
        }
        public string BasketScored()
        {
            foreach (Basket a in this.CourtBasket)
            {
                if (a.Loc.X == this.CourtBall.LocBall.X && a.Loc.Y == this.CourtBall.LocBall.Y)
                {
                    return "A ball has entered the basket";
                }
            }
            return "A ball has not gone into the basket";
        }
    }
}
