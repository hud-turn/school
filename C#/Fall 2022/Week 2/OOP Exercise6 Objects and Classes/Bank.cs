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
                Console.WriteLine(s.MemberName);
            }
            
        }
        public int GetAccountTypeCount(int accounttype)
        {
            if (accounttype == 1)
            {
                int count = 0;
                foreach (Member s in this.Members)
                {
                    if (s.Acct.CAcctstat == true)
                    {
                        count++;
                    }
                }
                return count;
            }
            if (accounttype == 2)
            {
                int count = 0;
                foreach (Member s in this.Members)
                {
                    if (s.Acct.SAcctstat == true)
                    {
                        count++;
                    }
                }
                return count;
            }
            else
            {
                return 0;
            }
        }
        //public int GetTransactionCount()
        //{

        //}
    }
    

}
