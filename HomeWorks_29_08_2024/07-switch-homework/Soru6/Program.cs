namespace Soru6;

class Program
{
    static void Main(string[] args)
    {

// Kullanıcıdan alınan bir nota göre (A, B, C, D, F) geçme veya kalma durumunu belirleyen bir program yazın.

        Console.Write("Lütfen Notu Giriniz ( 1 ile 100 Arasinda ) : ");
        int not = Convert.ToInt32(Console.ReadLine());

        switch(not){
        case not <= 100 : System.Console.WriteLine("A - Geçti"); break;
        case not <= 85 : System.Console.WriteLine("B - Geçti"); break;
        case not <= 60 : System.Console.WriteLine("C - Geçti"); break;
        case not <= 45 : System.Console.WriteLine("D - Kaldi"); break;
        case not <= 25 : System.Console.WriteLine("F - Kaldi"); break;

        default : System.Console.WriteLine("1 ile 100 arasinda bir not giriniz."); break;

        }
    }
}
