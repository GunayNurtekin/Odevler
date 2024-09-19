using System;

namespace Soru9;

public class Account
{
    public Account(int accountNumber, int balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public int AccountNumber { get; set; }
public int Balance { get; set; }


}
