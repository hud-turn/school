using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise8_Inheritance
{
    public class Account
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
            return "Account Removed";
        }
        public string AddFunds(double balance)
        {
            this.Balance += balance;
            return "Credit has been added to this account";
        }
        public double CheckBalance()
        {
            return this.Balance;
        }
        public int AcctGetTransactionCount()
        {
            int count = this.Transactions.Count();
            return count;
        }
    }
    //so we will add a method to the account class.
    //inheritance allows us to pull methods from the account class and reference them using another class without removing data/program and breaking crap.
    public class CheckingAccount : Account
    {
        public CheckingAccount(int memberid, bool acctstat, int accttype, double accountnum, double balance, List<double> transactions):base(memberid,acctstat,accttype,accountnum,balance,transactions)
        {

        }

    }
    public class SavingsAccount : Account
    {
        public SavingsAccount(int memberid, bool acctstat, int accttype, double accountnum, double balance, List<double> transactions) : base(memberid, acctstat, accttype, accountnum, balance, transactions)
        {

        }

    }
}
