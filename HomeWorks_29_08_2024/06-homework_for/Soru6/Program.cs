namespace Soru6;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan sayının kaç tane pozitif böleni olduğunu bulan bir program yazın.
        
        Console.Write("Bir Sayi Giriniz : ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int bolensayisi = 0;
        int i =1 ;
       

        for (i=1; i<=sayi ; i++) {

            if (sayi%i==0){
                System.Console.WriteLine(i);
                bolensayisi++;
            }
        }
        
       
        System.Console.WriteLine($"{sayi} sayisini bölen toplam {bolensayisi} değer vardir. ");
    }
}
