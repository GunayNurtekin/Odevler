using System;

namespace Soru2;

public class Car : Vehicle
{

    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public int NumberOfDoors { get; set; }

    public void TellmeSomething(){

        System.Console.WriteLine($"{Make},{Model} modelinde , {Year} model yilinda çok temiz bir araç");

    }

}
