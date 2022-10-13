using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise6_Objects_and_Classes
{
    internal class Account
    {
        public Account(int memberid, bool acctstat, int accttype, double accountnum, double balance, List<double> transactions)
        {
            this.MemberID = memberid;
            this.Acctstat = acctstat;
            this.AcctType = accttype;
            this.AccountNum = accountnum;
            this.Balance = balance;
            this.Transactions = transactions;
        }

        public int MemberID { get; set; }
        public bool Acctstat { get; set; }
        public double AcctType { get; set; }
        public double AccountNum { get; set; }
        public double Balance { get; set; }
        public List<double> Transactions { get; set; }
        public string CloseAccount()
        {
            this.Acctstat = false;
            return "Checking Account Removed";
        }
        public string AddFunds(double balance)
        {
            this.Balance += balance;
            return "Credit has been added to account";
        }
        public void CheckBalance()
        {
            Console.WriteLine(this.Balance);
        }
        public void GetTransactionCount()
        {
            Console.WriteLine(this.Transactions.Count());
        }
    }
}
