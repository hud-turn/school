using OOP_Exercise9_Inheritance;
using System;
using System.Security.Principal;

namespace OOP_Exercise9_Inheritance
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
            Basket Basket11 = new Basket(true, loc11);
            Basket Basket12 = new Basket(true, loc12);
            Basket Basket13 = new Basket(true, loc13);
            Basket Basket14 = new Basket(true, loc14);
            Basket Basket21 = new Basket(false, loc21);
            Basket Basket22 = new Basket(false, loc22);
            Basket Basket23 = new Basket(false, loc23);
            Basket Basket24 = new Basket(false, loc24);
            BasketList.Add(Basket11);
            BasketList.Add(Basket12);
            BasketList.Add(Basket13);
            BasketList.Add(Basket14);
            BasketList.Add(Basket21);
            BasketList.Add(Basket22);
            BasketList.Add(Basket23);
            BasketList.Add(Basket24);

            Location LocBall = new Location(10,0 );
            Ball Ball = new Ball(LocBall);

           
            Location locp11 = new Location(8, 6);
            Location locp12 = new Location(9, 3);
            Location locp13 = new Location(7, 3);
            Location locp21 = new Location(3, 6);
            Location locp22 = new Location(3, 5);
            Location locp23 = new Location(3, 7);        
            Player p11 = new Player(5, "Jim", locp11,0,1);
            Player p12 = new Player(5, "Pym", locp12,0,1);
            Player p13 = new Player(5, "Quin", locp13,0,1);
            Player p21 = new Player(6, "Harper", locp21,0,1);
            Player p22 = new Player(6, "Casey", locp22,0, 1);
            Player p23 = new Player(6, "Alex", locp23,0, 1);
            Player p24 = new Player(5, "Jimm", locp11, 0, 2);
            Player p25 = new Player(5, "Pymm", locp12, 0, 2);
            Player p26 = new Player(5, "Quinn", locp13, 0, 2);
            Player p27 = new Player(6, "Haarper", locp21, 0, 2);
            Player p28 = new Player(6, "Caseyy", locp22, 0, 2);
            Player p29 = new Player(6, "Alux", locp23, 0, 2);
            List <Player> teamgame = new List <Player>();
            teamgame.Add(p11);
            teamgame.Add(p12);
            teamgame.Add(p13);
            teamgame.Add(p21);
            teamgame.Add(p22);
            teamgame.Add(p23);
            teamgame.Add(p24);
            teamgame.Add(p25);
            teamgame.Add(p26);
            teamgame.Add(p27);
            teamgame.Add(p28);
            teamgame.Add(p29);

            Location refloc = new Location(6, 6);
            Reff referee = new Reff(refloc);

            Court courtgame = new Court(teamscores, BasketList ,Ball, teamgame, referee);

            Console.WriteLine("This is the list of players:");
            courtgame.ListAllMembers();

            Console.WriteLine("\nThis is the list of players and how close they are to the ref.:");
            courtgame.ClosestToReff();

            Console.WriteLine("\nThe following line indicates if a basket has been scored when the ball enters the basket:");
            Console.WriteLine(courtgame.BasketScored());

            Console.WriteLine("\nThe following line indicates if a basket has been scored during this game:");
            Console.WriteLine(courtgame.Scored());

            Console.ReadKey();
        }
    }
}