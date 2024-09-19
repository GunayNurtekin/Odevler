namespace Soru2;

public class Vehicle
{
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public string Make { get; set; }
    public string Model { get; set; }   
    public int Year { get; set; }
}
