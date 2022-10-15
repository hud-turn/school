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
            Location LocBall = new Location(5, 5);
            Ball Ball = new Ball(LocBall);

            Location loc11 = new Location(5, 0);
            Location loc12 = new Location(6, 0);
            Location loc13 = new Location(5, 1);
            Location loc14 = new Location(6, 1);
            Basket Basket1 = new Basket(true, loc11, loc12, loc13, loc14);

            Location loc21 = new Location(5, 10);
            Location loc22 = new Location(6, 10);
            Location loc23 = new Location(5, 9);
            Location loc24 = new Location(6, 9);
            Basket Basket2 = new Basket(false, loc21, loc22, loc23, loc24);

            Location refloc = new Location(6, 6);
            Reff referee = new Reff(refloc);

            Location p11 = new Location(6, 3);
            Location p12 = new Location(5, 3);
            Location p13 = new Location(7, 3);

            Location p21 = new Location(3, 6);
            Location p22 = new Location(3, 5);
            Location p23 = new Location(3, 7);

            List<Team> teamgame = new List<Team>();




        }
    }
}