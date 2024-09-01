namespace Soru9;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan iki sayı ve bir işlem (+, -, *, /) için basit bir hesap makinesi yapın.

    Console.Write("1.Sayi : ");
         int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("2.Sayi : ");
       int sayi2 = Convert.ToInt32(Console.ReadLine());



        Console.Write("Bir işlem Giriniz ( + - * / ) : ");
        string islem = Console.ReadLine();

        if(islem=="+"){
            int sonuc=sayi1+sayi2;
            System.Console.WriteLine(sonuc);
        }else if(islem=="-"){
            int sonuc=sayi1-sayi2;
            System.Console.WriteLine(sonuc);
        }else if(islem=="*"){
            int sonuc=sayi1*sayi2;
            System.Console.WriteLine(sonuc);
        }else if(islem=="/"){
            int sonuc=sayi1/sayi2;
            System.Console.WriteLine(sonuc);
        }else {
            System.Console.WriteLine("Belitilen isaretlerden birini seciniz.");
        }
    }
}
