namespace Soru4;

class Program
{
    static void Main(string[] args)
    {

// İki tarih arasındaki gün farkını hesaplayan bir program yazın.

 // Kullanıcıdan birinci tarihi al
        Console.Write("Birinci tarihi girin (GG-AA-YYYY formatında): ");
        string tarihInput1 = Console.ReadLine();

        // Kullanıcıdan ikinci tarihi al
        Console.Write("İkinci tarihi girin (GG-AA-YYYY formatında): ");
        string tarihInput2 = Console.ReadLine();

        try
        {
            // Girilen tarihleri uygun formata dönüştür
            DateTime tarih1 = DateTime.Parse(tarihInput1);
            DateTime tarih2 = DateTime.Parse(tarihInput2);

            // İki tarih arasındaki farkı hesapla
            TimeSpan fark = tarih2 - tarih1;

            // Gün farkını yazdır
            Console.WriteLine($"İki tarih arasındaki gün farkı: {Math.Abs(fark.Days)} gün");
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz tarih formatı! Lütfen GG-AA-YYYY formatında bir tarih girin.");
        }
        
    }
}
