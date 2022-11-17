using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise10_Interfaces
{
    public class Account
    {
        public Account(decimal balance)
        {
            this.Balance = balance;
        }
        public Account(decimal balance, decimal interest)
        {
            this.Balance = balance;
            this.Interest = interest;
        }
        public decimal Interest { get; set; }
        public decimal Balance { get; set; }
        public decimal getBalance()
        {
            return this.Balance;
        }
        public string getBalance(string prefix)
        {
            return prefix + this.Balance;
        }
        public int getBalance(int x)
        {
            return x + Convert.ToInt32(this.Balance);
        }
    }
}
