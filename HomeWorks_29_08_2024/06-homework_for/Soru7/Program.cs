using System.Runtime.Serialization.Formatters;

namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // Bir sayının mükemmel olup olmadığını bulan bir program yazın.

        // Kendisi hariç pozitif bölenlerinin toplamı kendisine eşit olan sayı

        Console.Write("Bir Sayi Giriniz : ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int toplam = 0 ;
        int i = 1;

        for(i=1; i<=sayi;i++){
            if (sayi%i==0){

                System.Console.WriteLine(i);
                toplam +=i;
              
            }
        }
        
        int mukemmelsayi =toplam-sayi;

        if(mukemmelsayi==sayi){
            System.Console.WriteLine("Girdiğiniz Sayı Mükemmel Sayidir.");
        }else
        System.Console.WriteLine("Girdiğiniz Sayi Mükemmel Sayi Değildir.");
    }
}
