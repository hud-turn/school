using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Member
    {
        public Member(double memeberid, string membername, Checking_Account chkacct, Savings_Account svgacct )
        {
            this.ChkAcct = chkacct;
            this.SvgAcct = svgacct;
        }
        public Checking_Account ChkAcct { get; set; }
        public Savings_Account SvgAcct { get; set; }
    }
    public Member Remove()
    {

    }
}
