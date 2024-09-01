namespace Soru8;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir sayının 3'e ve 5'e tam bölünüp bölünmediğini kontrol eden ve uygun mesajı veren bir program yazın.

        Console.Write("Bir Sayi Giriniz : ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if ( sayi%5==0 && sayi%3==0){
            System.Console.WriteLine($"Girmiş olduğunuz {sayi} sayisi 3 ve 5 ile kalansiz bölünmektedir.");
        }else{
            System.Console.WriteLine($"Girmiş olduğunuz {sayi} sayisi 3 veya 5 ile kalansiz bölünememektedir.");
        }
    }
}
