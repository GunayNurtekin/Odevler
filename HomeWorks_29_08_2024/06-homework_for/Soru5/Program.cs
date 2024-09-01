namespace Soru5;

class Program
{
    static void Main(string[] args)
    {   
        //Kullanıcıdan alınan sayıyı tersine çeviren bir program yazın. Ör: Sayı: 4982 Sonuç: 2894
        Console.Write("Bir Sayi Yaziniz : ");
        string sayi = Console.ReadLine();

        char [] rakamlar = sayi.ToCharArray();

    Array.Reverse(rakamlar);

    string yeniSiraRakamlar = new string(rakamlar);

    System.Console.WriteLine($"Girilen Sayının Tersten Yeniden Siralanmis Hali : {yeniSiraRakamlar}");

    }
}
