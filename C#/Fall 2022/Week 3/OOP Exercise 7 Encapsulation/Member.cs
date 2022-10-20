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
        public Member(int memberid, string membername, List<Account> accounts)
        {
            this.MemberID = memberid;
            this.MemberName = membername;
            this.Acct = accounts;
        }
        public double MemberID { get;}//Changes
        public string MemberName { get; set; }
        public List<Account> Acct { get; set; }

    }
}
