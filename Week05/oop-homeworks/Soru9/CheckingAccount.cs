using System;

namespace Soru9;

public class CheckingAccount : Account
{
    public CheckingAccount(int accountNumber, int balance) : base(accountNumber, balance)
    {
    }

    public void WriteCheck(){
        System.Console.WriteLine($"{AccountNumber} numarali hesabinizdan {Balance} değerinde çek yazilmiştir.");
    }
}
