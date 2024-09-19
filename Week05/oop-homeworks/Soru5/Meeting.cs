using System;

namespace Soru5;

public class Meeting : Event
{
    public Meeting(string? name, string? date, string? location) : base(name, date, location)
    {
    }

     public void MeetingMessage() 
    {
        System.Console.WriteLine($" {Name} Bey ! Toplantımız {Date} tarihinde {Location} de yapılacaktir. Toplantımıza katılımlarınızı bekliyoruz. ");
    }

}
