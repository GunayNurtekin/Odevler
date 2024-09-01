namespace Soru5;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan iki sayı için üs alma işlemi yapan bir program yazın (örneğin, 2^3).

        Console.Write("Bir sayi giriniz : ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üst için bir sayi giriniz : ");
        double ustsayi = Convert.ToDouble(Console.ReadLine());

        double sonuc = Math.Pow(sayi,ustsayi);

        System.Console.WriteLine($"Girdiğiniz {sayi} sayisinin , {ustsayi} üssü degeri = {sonuc}");
    }
}
