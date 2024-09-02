using System.Runtime.CompilerServices;

namespace Soru8;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir sayıya göre (0-6 arası) bir geometrik şeklin adını yazdıran bir program yazın (0: Nokta, 1: Çizgi, 2: Açı, 3: Üçgen, 4: Kare, 5: Beşgen, 6: Altıgen).

        Console.Write("0 ile 6 Arasinda Bir Sayi Giriniz : ");
        byte sayi = Byte.Parse(Console.ReadLine());

        switch (sayi){
            case 0 : System.Console.WriteLine("Nokta");break;
            case 1 : System.Console.WriteLine("Cizgi");break;
            case 2 : System.Console.WriteLine("Aci");break;
            case 3 : System.Console.WriteLine("Ücgen");break;
            case 4 : System.Console.WriteLine("Kare");break;
            case 5 : System.Console.WriteLine("Besgen");break;
            case 6 : System.Console.WriteLine("Altigen");break;

        default : System.Console.WriteLine("Farkli bir rakam girdiniz. Lütfen 0 ile 6 arasinda bir rakam giriniz");break;

        }
    }
}
