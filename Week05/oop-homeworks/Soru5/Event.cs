using System;

namespace Soru5;

public class Event
{
    public Event(string? name, string? date, string? location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public string? Name { get; set; }
    public string? Date { get; set; }
     public string? Location { get; set; }
}
