using System.Diagnostics;

namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan iki sayı ve bir işlem (+, -, *, /) için basit bir hesap makinesi yapın (switch kullanarak).
        
        Console.Write("1.Sayi : ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2.Sayi : ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Islem Giriniz (+, -, *, /) : ");
        string islem = Console.ReadLine();

        int sonuc;

        switch(islem){
            case "+" : sonuc=sayi1+sayi2; System.Console.WriteLine($"Girdiğiniz iki sayinin toplami {sonuc}");break;
            case "-" : sonuc=sayi1-sayi2; System.Console.WriteLine($"Girdiğiniz iki sayinin toplami {sonuc}");break;
            case "*" : sonuc=sayi1*sayi2; System.Console.WriteLine($"Girdiğiniz iki sayinin toplami {sonuc}");break;
            case "/" : sonuc=sayi1/sayi2; System.Console.WriteLine($"Girdiğiniz iki sayinin toplami {sonuc}");break;

            default : System.Console.WriteLine("Yanlış bir işlem girdiniz. Lütfen (+, -, *, /) işlemlerinden birini seçiniz "); break ;
        }

    }
}
