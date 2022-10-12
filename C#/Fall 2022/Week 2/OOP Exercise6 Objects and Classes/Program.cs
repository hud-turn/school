using In_Class_Work;
using OOP_Exercise6_Objects_and_Classes;
using System;
using System.Collections.Generic;

namespace In_Class_Work
{
    class Program
    {
        static void Main()
        {
            int userinput = 0;
            List<Member> members = new List<Member>();
            Bank BankOne = new Bank (members);
            List<double> ctransactions1 = new List<double>();
            List<double> ctransactions2 = new List<double>();
            List<double> ctransactions3 = new List<double>();
            List<double> ctransactions4 = new List<double>();
            List<double> stransactions1 = new List<double>();
            List<double> stransactions2 = new List<double>();
            List<double> stransactions3 = new List<double>();
            List<double> stransactions4 = new List<double>();

            Accounts Account1 = new Accounts(0001, 500, ctransactions1, 0001, 500, stransactions1);
            Accounts Account2 = new Accounts(0002, 500, ctransactions2, 0002, 500, stransactions1);
            Accounts Account3 = new Accounts(0003, 500, ctransactions3, 0003, 500, stransactions1);
            Accounts Account4 = new Accounts(0004, 500, ctransactions4, 0004, 500, stransactions1);

            Member Member1 = new Member(0001, "Tom", Account1);
            Member Member2 = new Member(0002, "Tim", Account2);
            Member Member3 = new Member(0003, "Tod", Account3);
            Member Member4 = new Member(0004, "Ted", Account4);

            members.Add(Member1);
            members.Add(Member2);
            members.Add(Member3);
            members.Add(Member4);

            foreach(Member s in members)
            {
                Console.WriteLine(s.MemberName);
            }

            //while (userinput != 5)
            //{
            //    Console.WriteLine("Please input what you would like to do:");
            //    userinput =int.Parse(Console.ReadLine());
            //    if(userinput == 1)
            //    {

            //    }
            //    else if(userinput == 2)
            //    {

            //    }
            //    else if (userinput == 3)
            //    {

            //    }
            //    else if (userinput == 4)
            //    {

            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
        }
    }
}