using System;
using OOP_Exercise8_Inheritance;

public class CheckingAccount : Account
{
    public CheckingAccount(int memberid, bool acctstat, int accttype, double accountnum, double balance, List<double> transactions) : base(memberid, acctstat, 1, accountnum, balance, transactions)
    {
        this.ChkMemberID = memberid;
        this.ChkAcctstat = acctstat;
        this.ChkAcctType = accttype;
        this.ChkAccountNum = accountnum;
        this.ChkBalance = balance;
        this.ChkTransactions = transactions;
    }
    public int ChkMemberID { get; set; }
    public bool ChkAcctstat { get; set; }
    public double ChkAcctType { get; }
    public double ChkAccountNum { get; set; }
    public double ChkBalance { get; set; }
    public List<double> ChkTransactions { get; set; }
}
public class SavingsAccount : Account
{
    public SavingsAccount(int memberid, bool acctstat, int accttype, double accountnum, double balance, List<double> transactions) : base(memberid, acctstat, 2, accountnum, balance, transactions)
    {
        this.SvgMemberID = memberid;
        this.SvgAcctstat = acctstat;
        this.SvgAcctType = accttype;
        this.SvgAccountNum = accountnum;
        this.SvgBalance = balance;
        this.SvgTransactions = transactions;
    }
    public int SvgMemberID { get; set; }
    public bool SvgAcctstat { get; set; }
    public double SvgAcctType { get; }
    public double SvgAccountNum { get; set; }
    public double SvgBalance { get; set; }
    public List<double> SvgTransactions { get; set; }
}
