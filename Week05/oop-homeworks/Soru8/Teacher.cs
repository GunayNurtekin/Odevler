using System;

namespace Soru8;

public class Teacher : Person
{
    public Teacher(string? name, int age, string? subjectTaught) : base(name, age)
    {
        SubjectTaught = subjectTaught;
    }


    public string? SubjectTaught { get; set; }

    public void AttendClass(){

        System.Console.WriteLine($"{Name} , {Age} yaşinda bir {SubjectTaught} Öğretmenidir. ");
    }


}
