namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayıya göre (1-7 arası) haftanın gününü yazdıran bir program yazın.
        Console.Write("Bir Sayi Giriniz ( 1 ile 7 Arasinda) : ");
        int sayi = Int32.Parse(Console.ReadLine());

        switch(sayi){
            case 1: System.Console.WriteLine("Pazartesi"); break;
            case 2 :System.Console.WriteLine("Sali"); break;
            case 3 :System.Console.WriteLine("Carsamba"); break;
            case 4 :System.Console.WriteLine("Persembe"); break;
            case 5 :System.Console.WriteLine("Cuma"); break;
            case 6 :System.Console.WriteLine("Cumartesi"); break;
            case 7 :System.Console.WriteLine("Pazar"); break;
       
        default : System.Console.WriteLine("Lütfen 1 ile 7 Arasinda deger giriniz."); break;

         }
    }
}
