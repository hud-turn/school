using In_Class_Work;
using OOP_Exercise5_Objects_and_Classes;
using System;
using System.Security.Principal;

namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            List<Score> teamscores = new List<Score>();
            Score teamone = new Score(false, 5);
            Score teamtwo = new Score(true, 7);
            teamscores.Add(teamone);
            teamscores.Add(teamtwo);

            List<Basket> BasketList = new List<Basket>();
            Location loc11 = new Location(5, 0);
            Location loc12 = new Location(6, 0);
            Location loc13 = new Location(5, 1);
            Location loc14 = new Location(6, 1);
            Location loc21 = new Location(5, 10);
            Location loc22 = new Location(6, 10);
            Location loc23 = new Location(5, 9);
            Location loc24 = new Location(6, 9);
            Basket Basket1 = new Basket(true, loc11, loc12, loc13, loc14);
            Basket Basket2 = new Basket(false, loc21, loc22, loc23, loc24);

            Location LocBall = new Location(5, 5);
            Ball Ball = new Ball(LocBall);

            List<Team> teamgame = new List<Team>();
            Location locp11 = new Location(6, 3);
            Location locp12 = new Location(5, 3);
            Location locp13 = new Location(7, 3);
            Location locp21 = new Location(3, 6);
            Location locp22 = new Location(3, 5);
            Location locp23 = new Location(3, 7);        
            Team p11 = new Team(false, "Jim", locp11);
            Team p12 = new Team(false, "Pym", locp12);
            Team p13 = new Team(false, "Quinn", locp13);
            Team p21 = new Team(true, "Harper", locp21);
            Team p22 = new Team(true, "Casey", locp22);
            Team p23 = new Team(true, "Alex", locp23);
            teamgame.Add(p11);
            teamgame.Add(p12);
            teamgame.Add(p13);
            teamgame.Add(p21);
            teamgame.Add(p22);
            teamgame.Add(p23);

            Location refloc = new Location(6, 6);
            Reff referee = new Reff(refloc);

            Court courtgame = new Court(teamscores, BasketList ,Ball, teamgame, referee);

        }
    }
}