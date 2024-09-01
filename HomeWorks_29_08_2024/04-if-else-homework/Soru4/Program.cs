namespace Soru4;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir yılın artık yıl olup olmadığını kontrol eden bir program yazın

        Console.Write("Bir Yıl Giriniz : ");
        int yil = Convert.ToInt32(Console.ReadLine());

        if ( yil%4==0){
            System.Console.WriteLine("Girilen yil artik yildir");
        }else 
        {
            System.Console.WriteLine("Girilen yil artik yil degildir.");
        }
    }
}
