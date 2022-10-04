using In_Class_Work;
using System;
namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            Players Coach = new Players("Coach", "Test1", 50);
            Players Player1 = new Players("Quarterback", "Test2", 20);
            Players Player2 = new Players("Runningback", "Test3", 22);
            Players Player3 = new Players("Runningback", "Test4", 24);
            Players Player4 = new Players("Wide Reciever", "Test5", 23);
            Players Player5 = new Players("Tight End", "Test6", 25);
            Players Player6 = new Players("Corner Backs", "Test7", 26);
            Players Player7 = new Players("Corner Backs", "Test8", 27);
            Players Player8 = new Players("Safeties", "Test9", 27);
            Players Player9 = new Players("Safeties", "Test10", 27);
            Players Player10 = new Players("Defensive Tackle", "Test11", 27);
            Players Player11 = new Players("Defensive End", "Test12", 27);
            Players Player12 = new Players("Line Backer", "Test13", 27);
            Players Player13 = new Players("Kicker", "Test14", 27);

            List<Players> listofplayers = new List<Players>();
            listofplayers.Add(Coach);
            listofplayers.Add(Player1);
            listofplayers.Add(Player2);
            listofplayers.Add(Player3);
            listofplayers.Add(Player4);
            listofplayers.Add(Player5);
            listofplayers.Add(Player6);
            listofplayers.Add(Player7);
            listofplayers.Add(Player8);
            listofplayers.Add(Player9);
            listofplayers.Add(Player10);
            listofplayers.Add(Player11);
            listofplayers.Add(Player12);
            listofplayers.Add(Player13);


            Team TeamOne = new Team("Broncos", "Denver", listofplayers);

            Console.WriteLine(TeamOne.TeamNameReturn() + TeamOne.CityNameReturn());
            
            Console.ReadKey();
        }
    }
}