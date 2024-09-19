using System;
using System.Dynamic;

namespace Soru4;

public class Book
{
    public Book(string title, string author, int pages, int ıSBN, bool ısBorrowed)
    {
        Title = title;
        Author = author;
        Pages = pages;
        ISBN = ıSBN;
        IsBorrowed = ısBorrowed;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int ISBN { get; set; }

    public bool IsBorrowed { get;private set; }

    public void Borrow(){

          if (IsBorrowed)
        {
            Console.WriteLine($"'{Title}' kitabı zaten ödünç alınmış.");
        }
        else
        {
            IsBorrowed = true;
            Console.WriteLine($"'{Title}' kitabı başarıyla ödünç alındı.");
        }

    }

    public void Return(){
        
            if (!IsBorrowed)
        {
            Console.WriteLine($"'{Title}' kitabı zaten kütüphanede.");
        }
        else
        {
            IsBorrowed = false;
            Console.WriteLine($"'{Title}' kitabı başarıyla iade edildi.");
        }

    }

}
