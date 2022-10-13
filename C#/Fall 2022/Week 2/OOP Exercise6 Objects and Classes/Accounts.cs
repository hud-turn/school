using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Account
    {
        public Account(int memberid, bool cacctstat,double caccountnum, double cbalance, List<double> ctransactions, bool sacctstat, double saccountnum, double sbalance, List<double> stransactions)
        {
            this.MemberID = memberid;
            this.CAcctstat = cacctstat;
            this.CAccountNum = caccountnum;
            this.CBalance = cbalance;
            this.CTransactions = ctransactions;
            this.SAcctstat = sacctstat;
            this.SAccountnum = saccountnum;
            this.SBalance = sbalance;
            this.STransactions = stransactions;
        }

        public int MemberID { get; set; }
        public bool CAcctstat { get; set; }
        public double CAccountNum { get; set; }
        public double CBalance { get; set; }
        public List<double> CTransactions { get; set; }
        public bool SAcctstat { get; set; }
        public double SAccountnum { get; set; }
        public double SBalance { get; set; }
        public List<double> STransactions { get; set; }
        public string CloseAccount(int memberid, int accttype)
        {
            if (memberid == this.MemberID)
            {
                if (accttype == 1)
                {
                    this.CAcctstat = false;
                    return "Checking Account Removed";
                }
                if (accttype == 2)
                {
                    this.SAcctstat = false;
                    return "Savings Account Removed";
                }
            }


            return "Account not found";
        }
    }
}
