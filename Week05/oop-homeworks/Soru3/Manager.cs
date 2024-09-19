using System;

namespace Soru3;

public class Manager : Employee
{
    public Manager(string? name, int ıd, int salary, int numberOfTeams) : base(name, ıd, salary)
    {
        NumberOfTeams = numberOfTeams;
    }

    public int NumberOfTeams { get; set; }

    public void TellmeSomething(){

        System.Console.WriteLine($"{Id} numarali {Name} , Manager pozisyonunda çalışmakta ve {Salary} TL maaş almakta ve {NumberOfTeams} takıma müdürlük yapmaktadir. ");

    }
}
