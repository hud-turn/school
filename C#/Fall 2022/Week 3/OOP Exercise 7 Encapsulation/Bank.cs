using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Bank
    {
        public Bank(List<Member> members)
        {
            this.Members = members;
        }
        public List<Member> Members { get; set; }


        public void ListAllMembers()
        {
            foreach (Member s in this.Members)
            {
                Console.WriteLine(s.MemberName + " " + s.MemberID);
            }            
        }
        public int GetAccountTypeCount(int accounttype)
        {
            int count = 0;
            foreach (Member s in this.Members)
            {
                foreach (Account a in s.Acct)
                {
                    if (a.AcctType == 1 && a.Acctstat == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int GetTransactionCount(int accounttype)
        {
            int count = 0;
            foreach (Member s in this.Members)
            {
                foreach (Account a in s.Acct)
                {
                    foreach (double d in a.Transactions)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }    
}
