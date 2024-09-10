using System.Data;

namespace Soru12;

class Program
{
    static void Main(string[] args)
    {
        // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en sık tekrar eden elemanı bulan ve kaç defa 
        //tekrarlandığını ekrana yazdıran bir program yazın. Bu işlemi bir foreach döngüsü ile gerçekleştirin.

        int [] dizi = new int [100];
        Random rnd = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i]=rnd.Next(0,100);
        }

    System.Console.WriteLine("Sayi Dizisi : \n");
        foreach (int d in dizi)
        {
            System.Console.Write(d+ " ");
        }

        int enCokTekrarEden = dizi[0];
        int enCokTekrarSayisi = 0;

         foreach (int mevcutEleman in dizi)
        {
            int tekrarSayisi = 0;

            // İkinci döngü, her elemanın tekrar sayısını buluyor
            foreach (int eleman in dizi)
            {
                if (mevcutEleman == eleman)
                {
                    tekrarSayisi++;
                }
            }

            // Eğer bu elemanın tekrar sayısı daha önce bulduğumuzdan büyükse, güncelle
            if (tekrarSayisi > enCokTekrarSayisi)
            {
                enCokTekrarSayisi = tekrarSayisi;
                enCokTekrarEden = mevcutEleman;
            }
        }

        Console.WriteLine($"\n En çok tekrar eden eleman: {enCokTekrarEden}, Tekrar sayısı: {enCokTekrarSayisi}\n");
       
    }
}
