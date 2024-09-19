using System;

namespace Soru2;

public class MotorCycle : Vehicle
{
    public MotorCycle(string make, string model, int year, int power) : base(make, model, year)
    {
      Power = power ;
    }

    public int Power { get; set; }

   
}
