using System;

namespace Soru3;

public class Developer: Employee
{
    public Developer(string? name, int ıd, int salary, string? programmingLanguage) : base(name, ıd, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public string? ProgrammingLanguage { get; set; }

      public void TellmeSomething(){

        System.Console.WriteLine($"{Id} numarali {Name} , developer pozisyonunda çalışmakta ve {Salary} TL maaş almakta ve {ProgrammingLanguage} dilini bilmektedir. ");

    }
}
