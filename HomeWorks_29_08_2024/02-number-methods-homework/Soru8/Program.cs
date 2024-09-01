namespace Soru8;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir sayının logaritmasını (doğal logaritma) hesaplayan bir program yazın.

        Console.Write("Bir Sayi Giriniz : ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        double log = Math.Log(sayi);

        System.Console.WriteLine($"Girdiğiniz sayinin logaritma degeri : {log}");
    }
}
