namespace Soru6;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir sayının trigonometrik sinüs değerini hesaplayan bir program yazın.

        Console.Write("Trigonometrik sinüs değeri hesaplanacak sayiyi giriniz : ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        double sinusDegeri = Math.Sin(sayi);

        System.Console.WriteLine($"Girdiğiniz {sayi} sayisinin sinüs degeri : {sinusDegeri}");
    }
}
