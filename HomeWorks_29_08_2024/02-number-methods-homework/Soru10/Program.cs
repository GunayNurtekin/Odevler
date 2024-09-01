namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan bir ondalıklı sayıyı, yine kullanıcıdan alınan ondalık basamak sayısına göre yuvarlayan bir program yazın.

        Console.Write("Bir Sayi Giriniz : ");
        double sayi = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kac Basamak Yuvarlansin : ");
        int yuvarla = Convert.ToInt32(Console.ReadLine());

        double sonuc = Math.Round(sayi,yuvarla);

        System.Console.WriteLine($"Sonucunuz : {sonuc}");


    }
}
