using In_Class_Work;
using OOP_Exercise6_Objects_and_Classes;
using System;
using System.Collections.Generic;
using System.Security.Principal;

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

            ctransactions1.Add(159.5);
            ctransactions1.Add(159.5);
            ctransactions2.Add(15.5);
            ctransactions3.Add(19.5);
            ctransactions4.Add(1595);
            ctransactions4.Add(1599);

            stransactions1.Add(159.5);
            stransactions1.Add(159.5);
            stransactions2.Add(15.5);
            stransactions3.Add(19.5);
            stransactions4.Add(1595);


            Chk_Account CAccount1 = new Chk_Account(0001, true, 0001, 500, ctransactions1);
            Chk_Account CAccount2 = new Chk_Account(0002, true, 0002, 500, ctransactions2);
            Chk_Account CAccount3 = new Chk_Account(0003, true, 0003, 500, ctransactions3);
            Chk_Account CAccount4 = new Chk_Account(0004, true, 0004, 500, ctransactions4);
            Svg_Account SAccount1 = new Svg_Account(0001, true, 0001, 500, stransactions1);
            Svg_Account SAccount2 = new Svg_Account(0002, true, 0002, 500, stransactions2);
            Svg_Account SAccount3 = new Svg_Account(0003, true, 0003, 500, stransactions3);
            Svg_Account SAccount4 = new Svg_Account(0004, true, 0004, 500, stransactions4);

            Member Member1 = new Member(0001, "Tom", CAccount1, SAccount1);
            Member Member2 = new Member(0002, "Tim", CAccount2, SAccount2);
            Member Member3 = new Member(0003, "Tod", CAccount3, SAccount3);
            Member Member4 = new Member(0004, "Ted", CAccount4, SAccount4);

            members.Add(Member1);
            members.Add(Member2);
            members.Add(Member3);
            members.Add(Member4);

            while (userinput != 5)
            {
                Console.WriteLine("Please input what you would like to do.\n1. Close an account\n2.Add Funds\n3.Check a Balance\n4.Get a transaction Count\n5.List all Members\n6.Get an account type count\n7.Get a transaction count");
                userinput = int.Parse(Console.ReadLine());
                Console.Clear();
                if (userinput == 1)
                {
                    Console.WriteLine("Please input the member ID that you would like to remove:");
                    userinput = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input if you would like to remove a checking or savings account.\n1.Checking\n2.Savings ");
                    userinput = int.Parse(Console.ReadLine());
                    if (userinput == 1)
                    {

                    }
                    else
                    {

                    }
                    userinput = 0;
                }
                else if (userinput == 2)
                {

                    userinput = 0;
                }
                else if (userinput == 3)
                {

                    userinput = 0;
                }
                else if (userinput == 4)
                {
                    Console.WriteLine("Please input the type of account you want to count using either a one or a two.\n1.Checking Account\n2.Savings Account");
                    userinput = int.Parse(Console.ReadLine());
                    Console.WriteLine(BankOne.GetTransactionCount(userinput));
                    Console.ReadKey();
                    userinput = 0;
                }
                else if (userinput == 5)
                {
                    BankOne.ListAllMembers();
                    Console.ReadKey();
                    userinput = 0;
                }
                else if (userinput == 6)
                {
                    Console.WriteLine("Please input the type of account you want to count using either a one or a two.\n1.Checking Account\n2.Savings Account");
                    userinput = int.Parse(Console.ReadLine());
                    Console.WriteLine(BankOne.GetAccountTypeCount(userinput));
                    Console.ReadKey();
                    userinput = 0;
                }
                else if (userinput == 7)
                {
                    Console.WriteLine("Please input the type of account you want to count using either a one or a two.\n1.Checking Account\n2.Savings Account");
                    userinput = int.Parse(Console.ReadLine());
                    Console.WriteLine(BankOne.GetTransactionCount(userinput));
                    Console.ReadKey();
                    userinput = 0;
                }
                else
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}