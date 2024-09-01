namespace Soru7;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan üç sayıdan en büyüğünü bulan bir program yazın.

        Console.Write("1.Sayi : ");
        int sayi1=Convert.ToInt32(Console.ReadLine());

        Console.Write("2.Sayi : ");
        int sayi2=Convert.ToInt32(Console.ReadLine());

        Console.Write("3.Sayi : ");
        int sayi3=Convert.ToInt32(Console.ReadLine());

        if ( sayi1>sayi2 && sayi1>sayi3  ){
            System.Console.WriteLine("En Büyük Sayı 1.Sayidir.");
        }else if (sayi2>sayi1 && sayi2>sayi3){
            System.Console.WriteLine("En Büyük Sayı 2.Sayidir.");
    }else if (sayi3>sayi2 && sayi3>sayi1){
        System.Console.WriteLine("En Büyük Sayı 3.Sayidir.");
    }
}}
