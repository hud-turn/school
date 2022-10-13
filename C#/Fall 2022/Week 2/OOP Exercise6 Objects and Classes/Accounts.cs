using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Account
    {
        public Account(bool cacctstat,double caccountnum, double cbalance, List<double> ctransactions, bool sacctstat, double saccountnum, double sbalance, List<double> stransactions)
        {
            this.CAcctstat = cacctstat;
            this.CAccountNum = caccountnum;
            this.CBalance = cbalance;
            this.CTransactions = ctransactions;
            this.SAcctstat = sacctstat;
            this.SAccountnum = saccountnum;
            this.SBalance = sbalance;
            this.STransactions = stransactions;
            
        }
        public bool CAcctstat { get; set; }
        public double CAccountNum { get; set; }
        public double CBalance { get; set; }
        public List<double> CTransactions { get; set; }
        public bool SAcctstat { get; set; }
        public double SAccountnum { get; set; }
        public double SBalance { get; set; }
        public List<double> STransactions { get; set; }

    }
}
