namespace Soru13;

class Program
{
    static void Main(string[] args)
    {
        // Bir dizideki tek sayıları toplayan ve bu toplamın çift mi, tek mi olduğunu kontrol eden bir program yazın. 
        // Toplamla birlikte eğer toplam tek ise, "Toplam tek sayı" mesajı, çift ise "Toplam çift sayı" mesajı ekrana yazdırılmalı.
    
        int [] dizi = new int [20];
        Random rnd = new Random();

        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i]=rnd.Next(0,100);
        }
   System.Console.WriteLine();
   System.Console.WriteLine("\n Dizideki sayilar : \n ");
        
        foreach (int d in dizi)
        {
            System.Console.Write(d+" ");
        }

        int [] tekSayilar = new int [20];
        int teksayiToplam =0;
        
        
         for (int i = 0; i < dizi.Length; i++)
        {
            if(dizi[i]%2!=0){
                tekSayilar[i]=dizi[i];
                teksayiToplam += dizi[i];
             
            }
        }
        
         System.Console.WriteLine();
   System.Console.WriteLine("\n Dizideki Tek sayilar : \n ");
     
      foreach (var t in tekSayilar)
      {
        System.Console.Write(t+" ");
      }

    System.Console.WriteLine("\n");
    System.Console.WriteLine($"Toplam değer : {teksayiToplam} ");
 
    if(teksayiToplam%2==0){
        System.Console.WriteLine("Toplam Cift Sayidir.");
    }else  System.Console.WriteLine("Toplam Tek Sayidir.");
             
   
        }
    
    }

