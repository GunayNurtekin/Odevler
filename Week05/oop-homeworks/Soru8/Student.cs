using System;

namespace Soru8;

public class Student : Person
{
    public Student(string? name, int age, int gradeLevel) : base(name, age)
    {
        GradeLevel = gradeLevel;
    }

    public int GradeLevel { get; set; }

    public void AttendClass(){

        System.Console.WriteLine($"Adı , {Name} olan ve {Age} yaşinda olan {GradeLevel} sinif öğrencisi derse katildi. ");
    }

}
