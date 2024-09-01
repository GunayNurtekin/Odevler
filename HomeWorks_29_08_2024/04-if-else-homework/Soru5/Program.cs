namespace Soru5;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan üç sayının bir üçgen oluşturup oluşturamayacağını kontrol eden bir program yazın. (Geometride üçgen teorisini araştırınız.)

        Console.Write("1.Sayi : ");
        int sayi1 =Convert.ToInt32(Console.ReadLine());

        Console.Write("2.Sayi : ");
        int sayi2 =Convert.ToInt32(Console.ReadLine());

        Console.Write("3.Sayi : ");
        int sayi3 =Convert.ToInt32(Console.ReadLine());

        if ( sayi1+sayi2>sayi3 || sayi1+sayi3>sayi2 || sayi2+sayi3>sayi1){
            System.Console.WriteLine("Girilen bu 3 sayi , ücgen olusturabilir.");
        }else
        {
            System.Console.WriteLine("Girilen bu 3 sayi , ücgen olusturamaz.");
        }
    }
}
