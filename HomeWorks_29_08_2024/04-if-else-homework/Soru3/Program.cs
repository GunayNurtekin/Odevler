namespace Soru3;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir karakterin sesli harf olup olmadığını kontrol eden bir program yazın. (Veya (||) operatörünü araştırınız.)

        Console.Write("Bir Harf Giriniz: ");
        char harf = Convert.ToChar(Console.ReadLine());

        if ( harf=='a' || harf=='b' || harf=='ı' || harf=='i' || harf=='o' ||harf=='ö' ||harf=='u' ||harf=='ü')
        {
                System.Console.WriteLine("Bir Sesli Harf Girdiniz.");
        }else {
            System.Console.WriteLine("Bir Sessiz Harf Girdiniz.");
        }
    }
}
