namespace Soru6;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir yılın artık yıl olup olmadığını kontrol eden bir program yazın.

        // Kullanıcıdan yıl bilgisini al
        Console.Write("Bir yıl girin: ");
        string yilInput = Console.ReadLine();

        // Yılın geçerli bir sayı olup olmadığını kontrol et
        int yil;
        if (int.TryParse(yilInput, out yil))
        {
            // Artık yıl kontrolü yap
            if ((yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0))
            {
                Console.WriteLine($"{yil} bir artık yıldır.");
            }
            else
            {
                Console.WriteLine($"{yil} bir artık yıl değildir.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz yıl formatı! Lütfen geçerli bir yıl girin.");
        }
    }
}
