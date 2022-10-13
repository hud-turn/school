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
                    if (s.Chk_Acct.CAcctstat == true)
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
                    if (s.Svg_Acct.SAcctstat == true)
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
        public int GetTransactionCount(int accounttype)
        {
            if (accounttype == 1)
            {
                int count = 0;
                foreach (Member s in this.Members)
                {
                    for (double i = 0; i != s.Chk_Acct.CTransactions.Count();i++)
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
                    for (double i = 0; i != s.Svg_Acct.STransactions.Count(); i++)
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
    }    
}
