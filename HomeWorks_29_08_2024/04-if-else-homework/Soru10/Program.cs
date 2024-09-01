namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayının asal olup olmadığını kontrol eden bir program yazın.

        Console.Write("Bir Sayi Giriniz : ");
        int sayi=Convert.ToInt32(Console.ReadLine());

         if (sayi <= 1)
        {
            Console.WriteLine($"{sayi} asal bir sayı değildir.");
            return;
        }

        // Asallık kontrolü için basit bir yöntem
        bool asalMi = true;
        int i = 2;

        while (i < sayi)
        {
            if (sayi % i == 0)
            {
                asalMi = false; // Eğer sayi, i'ye tam bölünüyorsa, asal değildir.
                break;
            }
            i++;
        }

        if (asalMi)
        {
            Console.WriteLine($"{sayi} bir asal sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} asal bir sayı değildir.");
        }
    }
}
