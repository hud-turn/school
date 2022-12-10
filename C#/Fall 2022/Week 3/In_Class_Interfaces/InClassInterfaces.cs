using System;
using System.Collections.Generic;
using System.Security.Principal;
public class Account
{
    public Account(string firstName, string lastName, string type)
    {
        FirstName = firstName;
        LastName = lastName;
        Type = type;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Type { get; set; }
}

public interface ITransaction
{
    void showTransaction();
    double getAmount();
}
public interface IIntrest
{
    decimal interestRate { get; set; }
    void applyInterestRate();
}

public class SavingsAccount: Account, ITransaction, IIntrest
{

}

public class CheckingAccount: Account, ITransaction
{

}