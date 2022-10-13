using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

    }
}
