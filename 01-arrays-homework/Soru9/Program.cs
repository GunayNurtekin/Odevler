namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        // Verilen bir dizinin yalnızca pozitif sayılarını ters çeviren bir algoritma yazın. 
        //Diziyi tararken, sadece pozitif sayıların yerini değiştirmelisiniz, diğer elemanlar aynı kalmalı.

        // Diziyi oluşturalım

        int [] dizi = new int [10];
        Random rnd = new Random ();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi [i] = rnd.Next(-20,20); 
        }

        System.Console.Write( " \n Mevcut Dizi : \n");
        foreach (int d in dizi)
        {
            System.Console.Write( d + " ");
        }

        System.Console.Write( "\n ");
        int [] pozitif = new int [10];
        int pozitifSayac=0;

        for (int i = 0; i < dizi.Length; i++)
        {
           if (dizi[i]>0)
           {
            pozitif [pozitifSayac]= dizi[i];
            pozitifSayac++;
           }
        }

        // Pozitif sayıları ters sırayla dizideki pozitif sayıların yerine koyma

        int tersIndex = pozitifSayac - 1;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > 0)
            {
                dizi[i] = pozitif[tersIndex];
                tersIndex--;
            }
        }


        Console.WriteLine("\n Pozitif Sayıları Ters Çevrilmiş Dizi: \n");

        foreach (int sayi in dizi)
        {
            System.Console.Write( sayi + " ");
        }


    }
}
