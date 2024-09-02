namespace Soru7;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türk para biriminin adını yazdıran bir program yazın (1 Kr, 5 Kr, 10 Kr, 25 Kr, 50 Kr).
    
        Console.Write("Bir Sayi Giriniz ( 1 ile 5 Arasinda ): ");
        byte sayi = Convert.ToByte(Console.ReadLine());

        switch ( sayi ){

            case 1: System.Console.WriteLine("1 Kr");break;
            case 2: System.Console.WriteLine("5 Kr");break;
            case 3: System.Console.WriteLine("10 Kr");break;
            case 4: System.Console.WriteLine("25 Kr");break;
            case 5: System.Console.WriteLine("50 Kr");break;

            default : System.Console.WriteLine("Geçerli Bir Sayi Girmediniz.1 ile 5 arasinda bir sayi giriniz");break;
        }
    }
}
