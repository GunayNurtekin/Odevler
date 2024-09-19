using System;

namespace Soru9;

public class SavingsAccount : Account
{
    public SavingsAccount(int accountNumber, int balance) : base(accountNumber, balance)
    {
    }

public void AddMoney()

{
System.Console.WriteLine($"{AccountNumber} numarali hesabinizdaki {Balance } TL tutarinize , 15000 Tl Eklendi.");
}


}
