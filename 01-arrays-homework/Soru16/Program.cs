namespace Soru16;

class Program
{
    static void Main(string[] args)
    {
        //do-while döngüsü kullanarak, klavyeden girilen sayıları bir diziye ekleyin. 
        //Kullanıcı sıfır girdiğinde döngüden çıkın ve dizideki tüm sayılarla birlikte ortalamayı ekrana yazdırın.

        // Dinamik bir dizi (liste benzeri davranış) için başlangıçta büyük bir dizi tanımlayalım
        int[] sayilar = new int[100];
        int sayac = 0;
        int toplam = 0;
        int girilenSayi;
        
        do
        {
            Console.Write("Bir sayi girin (çikmak için 0 girin): ");
            girilenSayi = Convert.ToInt32(Console.ReadLine());

            // Sıfır değilse diziye ekleyelim
            if (girilenSayi != 0)
            {
                sayilar[sayac] = girilenSayi;
                toplam += girilenSayi; // Toplamı güncelle
                sayac++; // Sayaç ile eleman sayısını takip edelim
            }

        } while (girilenSayi != 0);

        // Dizideki elemanları ve ortalamayı ekrana yazdıralım
        if (sayac > 0) // Eğer diziye eleman eklendiyse
        {
            Console.WriteLine("\nGirilen Sayılar:");
            for (int i = 0; i < sayac; i++)
            {
                Console.Write(sayilar[i] + " ");
            }

            // Ortalama hesaplama
            double ortalama = (double)toplam / sayac;
            Console.WriteLine($"\n\nOrtalama: {ortalama}");
        }
        else
        {
            Console.WriteLine("Hiçbir sayı girilmedi.");
        }
    }
}
