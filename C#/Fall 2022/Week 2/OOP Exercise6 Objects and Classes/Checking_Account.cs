using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Checking_Account
    {
        public Checking_Account(double caccountnum, double balance, List<double> transactions)
        {
            this.CAccountNum = caccountnum;
            this.Balance = balance;
            this.Transactions = transactions;
        }
        public double CAccountNum { get; set; }
        public double Balance { get; set; }
        public List<double> Transactions { get; set; }

    }
    public double Add()
    {

    }
    public double AddFunds()
    {

    }
    public double CheckBalance()
    {

    }
    public int GetTransactionCount()
    {

    }
}
