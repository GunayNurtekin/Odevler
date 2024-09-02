namespace Soru2;

class Program
{

    
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir sayıya göre (1-12 arası) ayın adını yazdıran bir program yazın.

        Console.Write("Bir Sayi Giriniz ( 1-12 arasinda ) : ");
        int sayi = Int32.Parse(Console.ReadLine());

        switch(sayi){
            case 1 : System.Console.WriteLine("Ocak"); break;
            case 2 : System.Console.WriteLine("Şubat"); break;
            case 3 : System.Console.WriteLine("Mart"); break;
            case 4 : System.Console.WriteLine("Nisan"); break;
            case 5 : System.Console.WriteLine("Mayis"); break;
            case 6 : System.Console.WriteLine("Haziran"); break;
            case 7 : System.Console.WriteLine("Temmuz"); break;
            case 8 : System.Console.WriteLine("Agustos"); break;
            case 9 : System.Console.WriteLine("Eylül"); break;
            case 10 : System.Console.WriteLine("Ekim"); break;
            case 11 : System.Console.WriteLine("Kasim"); break;
            case 12 : System.Console.WriteLine("Aralik"); break;
            
            default : System.Console.WriteLine(" Lütfen 1-12 arasinda bir sayi giriniz."); break;
        }
    }
}
