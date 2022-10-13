using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Chk_Account
    {
        public Chk_Account(int memberid, bool cacctstat,double caccountnum, double cbalance, List<double> ctransactions)
        {
            this.MemberID = memberid;
            this.CAcctstat = cacctstat;
            this.CAccountNum = caccountnum;
            this.CBalance = cbalance;
            this.CTransactions = ctransactions;
        }

        public int MemberID { get; set; }
        public bool CAcctstat { get; set; }
        public double CAccountNum { get; set; }
        public double CBalance { get; set; }
        public List<double> CTransactions { get; set; }
        public string CCloseAccount(int memberid)
        {
            if (memberid == this.MemberID)
            {
                this.CAcctstat = false;
                return "Checking Account Removed";
            }
            else
            {
                return "Account not found";
            }
        }
    }
}
