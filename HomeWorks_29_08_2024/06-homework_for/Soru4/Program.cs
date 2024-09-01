namespace Soru4;

class Program
{
    static void Main(string[] args)
    {   //Kullanıcıdan alınan sayının çarpanlarını bulup bu çarpanların toplamını hesaplayan bir program yazın
        Console.Write("Bir Sayi Giriniz : ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int toplam =0;
        int sayac = 1 ;
        for ( sayac=1 ; sayac<=sayi ; sayac ++ ){

            if (sayi%sayac==0){

        System.Console.WriteLine(sayac);
        toplam += sayac;

            }
        }
        System.Console.WriteLine($"{sayi}  sayisinin carpanlarinin toplami: {toplam}");
    }
}
