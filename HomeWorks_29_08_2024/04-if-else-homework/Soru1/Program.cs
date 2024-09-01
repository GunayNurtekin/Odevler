namespace Soru1;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir sayının pozitif, negatif veya sıfır olduğunu kontrol eden bir program yazın.

        Console.Write("Bir Sayı Giriniz : ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if(sayi>0){
            System.Console.WriteLine("Girilen Sayı Pozitif.");
        }else if (sayi==0){
            System.Console.WriteLine("Girilen Sayı Sıfırdır.");
        }else {
            System.Console.WriteLine("Girilen Sayı Negatiftir.");
        }
    }
}
