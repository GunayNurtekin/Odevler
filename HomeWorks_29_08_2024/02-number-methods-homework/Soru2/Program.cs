namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan iki sayıdan hangisinin daha büyük olduğunu bulan bir program yazın.
       
        Console.Write("Lütfen Birinci sayiyi Giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lütfen İkinci sayiyi Giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double maxSayi = Math.Max(sayi1,sayi2);

        System.Console.WriteLine($"Girdiğiniz sayilar arasindan büyük olan : {maxSayi} sayisidir.");

    }
}
