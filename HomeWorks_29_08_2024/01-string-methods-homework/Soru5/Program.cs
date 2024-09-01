namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
          Console.Write("Lütfen bir metin giriniz: ");
        string anaMetin = Console.ReadLine();

        // Kullanıcıdan aramak istediği alt metni alın
        Console.Write("Lütfen aramak istediğiniz metni giriniz: ");
        string arananMetin = Console.ReadLine();

        // Ana metinde aranan metnin ilk indeksini bulun
        int ilkIndeks = anaMetin.IndexOf(arananMetin, StringComparison.OrdinalIgnoreCase);

        // Sonucu kontrol et ve ekrana yazdır
        if (ilkIndeks != -1)
        {
            Console.WriteLine($"\"{arananMetin}\" metni, \"{anaMetin}\" içinde ilk olarak {ilkIndeks}. indeksinde bulunuyor.");
        }
        else
        {
            Console.WriteLine($"\"{arananMetin}\" metni, \"{anaMetin}\" içinde bulunamadı.");
        }
    }
}

