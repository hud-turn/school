using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Member
    {
        public Member(int memberid, string membername, Account acct)
        {
            this.MemberID = memberid;
            this.MemberName = membername;
            this.Acct = acct;
        }
        public double MemberID { get; set; }
        public string MemberName { get; set; }
        public Account Acct { get; set; }

        //public List<Account> Stuff { get; set; }
    }

   
    //public double AddFunds(int memberid, int accountsel, double accounttransaction)
    //{
    //    if (accountsel == 0)
    //    {
    //        return 0;
    //    }
    //    else if (accountsel == 1)
    //    {
    //        return 1;
    //    }
    //}
    //public double CheckBalance(int memberid, int accountsel, double accountbal)
    //{
    //    if (accountsel == 0)
    //    {
    //        return 0;
    //    }
    //    else if (accountsel == 1)
    //    {

    //    }
    //}
    //public int GetTransactionCount(int memberid, int accountsel, int transactionct)
    //{
    //    if (accountsel == 0)
    //    {
    //        return 0;
    //    }
    //    else if (accountsel == 1)
    //    {

    //    }
    //}
}
