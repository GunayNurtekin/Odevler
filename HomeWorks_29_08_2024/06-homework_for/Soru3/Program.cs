namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan sayının rakamlarını küçükten büyüğe sıralayan bir program yazın. Ör: Sayı: 9375 Sonuç: 3,5,7,9

        Console.Write("Bir Sayi Giriniz : ");
        string sayi = Console.ReadLine();
        char [] rakamlar = sayi.ToCharArray();

        Array.Sort(rakamlar);

        string siralirakamlar = new string(rakamlar);

        System.Console.WriteLine($"Girdiğiniz rakamdan türetilmiş , değerleri küçükten büyüğe siralanmis yeni rakam : {siralirakamlar}"); 
    }
}
