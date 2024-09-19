namespace Soru4;

class Program
{
  
//Bir Book (Kitap) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
// Title (başlık): Kitap başlığı
// Author (yazar): Yazarın adı
// Pages (sayfa sayısı): Kitap sayfa sayısı
// ISBN (ISBN numarası): Kitap ISBN numarası
// Book sınıfına Borrow (Ödünç Al) ve Return (İade Et) metodlarını ekleyin. Daha sonra bir Library (Kütüphane) sınıfı oluşturun ve içinde bir dizi Book nesnesi tutarak bu kitapları yönetebilsin.
    
  static void Main(string[] args)
    {
      
        // Kütüphane oluştur
        Library library = new Library();

        // Kitapları oluştur
        Book book1 = new Book("Kitap 1", "Yazar 1", 300, 1234567890,true);
        Book book2 = new Book("Kitap 2", "Yazar 2", 150, 0987654321,false);

        // Kütüphaneye kitap ekle
        library.AddBook(book1);
        library.AddBook(book2);

        // Kütüphanedeki kitapları listele
        Console.WriteLine("\nKütüphanedeki kitaplar:");
        library.ListBooks();

        // Kitap ödünç al
        Console.WriteLine("\nÖdünç alma işlemi:");
        book1.Borrow();

        // Kitabı tekrar ödünç almaya çalış
        book1.Borrow();

        // Kitap iade et
        Console.WriteLine("\nİade işlemi:");
        book1.Return();

        // Kitabı tekrar iade etmeye çalış
        book1.Return();

        // ISBN ile kitap bul
        Console.WriteLine("\nISBN ile kitap bul:");
        Book foundBook = library.FindBookByISBN(1234567890);
        if (foundBook != null)
        {
            Console.WriteLine(foundBook);
        }
    }
}
    
    

