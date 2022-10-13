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
        public Member(int memberid, string membername, Chk_Account cacct, Svg_Account sacct)
        {
            this.MemberID = memberid;
            this.MemberName = membername;
            this.Chk_Acct = cacct;
            this.Svg_Acct = sacct;
        }
        public double MemberID { get; set; }
        public string MemberName { get; set; }
        public Chk_Account Chk_Acct { get; set; }
        public Svg_Account Svg_Acct { get; set; }

    }
}
