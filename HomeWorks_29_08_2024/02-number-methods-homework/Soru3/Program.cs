namespace Soru3;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir sayının mutlak değerini hesaplayan bir program yazın.

        Console.Write("Bir Sayi Giriniz : ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        double mutlakSayi = Math.Abs(sayi);

        System.Console.WriteLine($"Girdiğiniz sayının mutlak değeri : {mutlakSayi}");
    }
}
