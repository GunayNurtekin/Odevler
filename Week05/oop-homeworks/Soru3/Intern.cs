using System;

namespace Soru3;

public class Intern : Employee
{
    public Intern(string? name, int ıd, int salary) : base(name, ıd, salary)
    {
    }

     public void TellmeSomething(){

        System.Console.WriteLine($"{Id} numarali {Name} , Intern pozisyonunda çalışmakta ve {Salary} TL maaş almaktadir. ");

    }
}
