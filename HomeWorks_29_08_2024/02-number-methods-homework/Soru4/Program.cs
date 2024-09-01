namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        
        // Kullanıcıdan alınan bir sayının karekökünü hesaplayan bir program yazın.

        Console.Write("Bir Sayi Giriniz: ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        double karekokSayi = Math.Sqrt(sayi);

        System.Console.WriteLine($"Girdiğiniz sayinin karekok degeri : {karekokSayi}");
    }
}
