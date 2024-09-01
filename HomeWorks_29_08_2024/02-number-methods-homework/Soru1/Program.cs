namespace Soru1;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir ondalıklı sayıyı en yakın tam sayıya yuvarlayan bir program yazın.

        Console.Write("Lütfen Ondalıklı bir sayı giriniz: ");
        Double sayi = Convert.ToDouble(Console.ReadLine());

        double yuvarlanmisSayi = Math.Round(sayi);

        System.Console.WriteLine($"Girdiğiniz sayının yuvarlanmış hali : {yuvarlanmisSayi}");
       
    }
}
