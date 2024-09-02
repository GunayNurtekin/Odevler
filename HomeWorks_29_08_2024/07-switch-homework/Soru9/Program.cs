using System.Runtime.CompilerServices;

namespace Soru9;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türkçe sayı sıfatını yazdıran bir program yazın (1: Birinci, 2: İkinci, vb.)

        Console.Write("1 ile 5 Arasinda Bir Sayi Giriniz : ");
        byte sayi = Convert.ToByte(Console.ReadLine());

        switch(sayi){
            case 1: System.Console.WriteLine("1: Birinci"); break;
            case 2: System.Console.WriteLine("2: İkinci"); break;
            case 3: System.Console.WriteLine("3: Üçüncü"); break;
            case 4: System.Console.WriteLine("4: Dörtçü"); break;
            case 5: System.Console.WriteLine("5: Beşinci"); break;

            default : System.Console.WriteLine("Yanlış bir numara girdiniz.Lütfen 1 ile 5 Arasinda Bir Sayi Giriniz");break;
        }
    }
}
