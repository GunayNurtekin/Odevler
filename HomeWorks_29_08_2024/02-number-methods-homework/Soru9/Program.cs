namespace Soru9;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan iki sayı arasındaki küçük olanı bulan bir program yazın.

        Console.Write("1. Sayi: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. Sayi: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double minSayi = Math.Min(sayi1,sayi2);

        System.Console.WriteLine($"Girdiginiz degerler arasinda en kucuk olan sayi : {minSayi} sayisidir.");
    }
}
