using OOP_Exercise10_Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Principal;

namespace OOP_Exercise10_Interfaces
{
    class Program
    {
        static void Main()
        {
            List<Hotel> hotelList = new List<Hotel>();
            Hotel example1 = new Hotel(1568574, 6542385, 263544, 6543621);
            hotelList.Add(example1);

            Zombie zombie = new Zombie();
            zombie.Undead();
        }
        
    }
}