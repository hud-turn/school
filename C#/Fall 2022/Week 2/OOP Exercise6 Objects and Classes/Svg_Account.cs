using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Svg_Account
    {
        public Svg_Account(int memberid,bool sacctstat, double saccountnum, double sbalance, List<double> stransactions)
        {
            this.MemberID = memberid;
            this.SAcctstat = sacctstat;
            this.SAccountnum = saccountnum;
            this.SBalance = sbalance;
            this.STransactions = stransactions;
        }

        public int MemberID { get; set; }
        public bool SAcctstat { get; set; }
        public double SAccountnum { get; set; }
        public double SBalance { get; set; }
        public List<double> STransactions { get; set; }
        public string CCloseAccount()
        {
            this.SAcctstat = false;
            return "Checking Account Removed";
        }
    }
}
