using System;

namespace Soru4;

public class Library 
{

public Library()
{
    books = new List<Book>();
}
 private List<Book> books;


    // Kütüphaneye kitap ekleme metodu
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"{book.Title} kitabı kütüphaneye eklendi.");
    }

    // Kütüphanedeki kitapları listeleme metodu
    public void ListBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Kütüphanede kitap yok.");
            return;
        }

        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    // ISBN ile kitap bulma metodu
    public Book FindBookByISBN(int isbn)
    {
        foreach (var book in books)
        {
            if (book.ISBN == isbn)
            {
                return book;
            }
        }
        Console.WriteLine("Kitap bulunamadı.");
        return null ;
        
    }
}

