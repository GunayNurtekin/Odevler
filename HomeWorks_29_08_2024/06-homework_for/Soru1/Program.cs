using System.Xml;

namespace Soru1;

class Program
{
    static void Main(string[] args)
    {

        // 0'dan girilen sayıya kadar olan sayılardan aynı anda hem 3'ün hem de4'ün katı olan sayıların ortalamasını hesaplayan programı yazınız. Ör: 24 sayısı girilmiş ise 12 ve 24 hem 3'ün hem de 4'ün katıdır, ortalama 18 çıkacaktır.

        Console.Write("Bir Sayi Giriniz : ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;
        int sayac = 0 ;

        for(int x =1; x<=sayi; x++ ){

            if(x%12==0){
                toplam += x;
                sayac ++;
            }
        } if (sayac > 0)
        {
            double ortalama = (double)toplam / sayac;
            Console.WriteLine($"0'dan {sayi}'ya kadar olan hem 3'ün hem de 4'ün katı olan sayıların ortalaması: {ortalama}");
        }
        else
        {
            Console.WriteLine("Girilen aralıkta hem 3'ün hem de 4'ün katı olan bir sayı yok.");
        }
    }
}
