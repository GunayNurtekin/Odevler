namespace Soru4;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir harfe göre sesli veya sessiz harf olduğunu belirleyen bir program yazın.
        Console.Write("Bir Harf Giriniz : ");
        char harf = Convert.ToChar(Console.ReadLine());

        switch(harf){
            case 'a': System.Console.WriteLine("Sesli Harf Girdiniz.");break;
            case 'e': System.Console.WriteLine("Sesli Harf Girdiniz.");break;
            case 'ı': System.Console.WriteLine("Sesli Harf Girdiniz.");break;
            case 'i': System.Console.WriteLine("Sesli Harf Girdiniz.");break;
            case 'o': System.Console.WriteLine("Sesli Harf Girdiniz.");break;
            case 'ö': System.Console.WriteLine("Sesli Harf Girdiniz.");break;
            case 'u': System.Console.WriteLine("Sesli Harf Girdiniz.");break;
            case 'ü': System.Console.WriteLine("Sesli Harf Girdiniz.");break;


            default: System.Console.WriteLine("Sessiz Harf Girdiniz.");break;
        }
    }
}
