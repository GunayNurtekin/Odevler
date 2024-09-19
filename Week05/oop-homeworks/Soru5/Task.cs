using System;

namespace Soru5;

public class Task : Event
{
    public Task(string? name, string? date, string? location) : base(name, date, location)
    {
    }


    public void MarkAsComplete(){
        System.Console.WriteLine($"Merhaba {Name } , Görev Tamamlandi ! Bir sonraki görev {Date} tarihinde. Detaylar için {Location} de buluşalım");
    }
}
