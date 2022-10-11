using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Accounts
    {
        public Accounts(double caccountnum, double cbalance, List<double> ctransactions, double saccountnum, double sbalance, List<double> stransactions)
        {
            this.CAccountNum = caccountnum;
            this.CBalance = cbalance;
            this.CTransactions = ctransactions;
            this.SAccountnum = saccountnum;
            this.SBalance = sbalance;
            this.STransactions = stransactions;
        }
        public double CAccountNum { get; set; }
        public double CBalance { get; set; }
        public List<double> CTransactions { get; set; }
        public double SAccountnum { get; set; }
        public double SBalance { get; set; }
        public List<double> STransactions { get; set; }

    }
    public double AddFunds(int accountsel, double accounttransaction)
    {

    }
    public double CheckBalance()
    {

    }
    public int GetTransactionCount()
    {

    }
}
