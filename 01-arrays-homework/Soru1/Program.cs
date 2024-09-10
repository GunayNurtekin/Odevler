using System.Collections.Concurrent;

namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisi içinde, dizinin her bir elemanının yalnızca bir önceki 
        // ve bir sonraki elemanı ile kıyaslandığı bir algoritma yazın. Bu algoritma, yalnızca kendinden önceki sayı ve kendinden 
        // sonraki sayı büyük olan elemanları bulmalı ve bunları ekrana yazdırmalıdır
    
    Random rnd = new Random();
    int [] sayilar =new int[10];
   

    for (int i =0 ; i<sayilar.Length ; i++ ){
        sayilar[i] =rnd.Next(1,100);

    }
        System.Console.WriteLine("Oluşturulan Sayi Dizisi:");

    foreach (int dizi in sayilar)
            {
                System.Console.Write(dizi+" ");
            }
                Console.WriteLine("\n");

    for(int i=1 ; i<sayilar.Length-1 ; i++)
{


    if(sayilar[i]>sayilar[i+1] && sayilar[i]>sayilar[i-1])
            {
                System.Console.WriteLine($"{i+1}. siradaki {sayilar[i]} elemani , {sayilar[i-1]} ve {sayilar[i+1]} değerinden büyüktür.\n");
            }

}
    
    }
}
