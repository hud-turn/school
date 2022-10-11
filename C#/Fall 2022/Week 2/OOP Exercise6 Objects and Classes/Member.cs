using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Member
    {
        public Member(double memberid, string membername, Accounts accts)
        {
            this.MemberID = memberid;
            this.MemberName = membername;
            this.ChkAcct = accts;
        }
        public double MemberID { get; set; }
        public string MemberName { get; set; }
        public Accounts ChkAcct { get; set; }
    }
    public Member RemoveAcct(int userinput, double memberid, Accounts removeaccts)
    {
        if (userinput == 1)
        {
            return;
        }
        else if(userinput == 2)
        {
            return;
        }
    }
}
