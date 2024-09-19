using System;

namespace Soru5;

public class Birthday : Event
{
    public Birthday(string? name, string? date, string? location) : base(name, date, location)
    {
    }

    public void congratulatoryMessage() 
    {
        System.Console.WriteLine($"Doğum günün kutlu olsun {Name} ! Doğum günü partisine katilmak isteyenleri {Date} tarihinde {Location} de bekliyoruz ");
    }
}
