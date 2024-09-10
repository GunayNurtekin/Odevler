using System.Diagnostics;

namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // Klavyeden girilen bir sayıyı, 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde aratın. 
        //Eğer sayı dizide yoksa, diziyi sıralayın ve sayıyı dizinin doğru(olması gereken sıra) yerine ekleyin. 
        //Ekledikten sonra yeni diziyi ekrana yazdırın.

        // Kullanıcıdan bir sayi alalim
        Console.Write("Bir Sayi Giriniz ( 1 ile 100 Arasinda ): ");
        int girilenSayi = Convert.ToInt32(Console.ReadLine());

         // Rastgele 10 sayidan oluşan diziyi oluşturalim.

         int [] dizi = new int [10] ;
         Random rnd = new Random();



         for( int i =0 ; i<dizi.Length ; i++)

         {
            dizi[i]=rnd.Next(0,100);
         }

         Array.Sort(dizi);
    System.Console.WriteLine("\nMevcut Dizi : \n");
         foreach (int eskidizi in dizi)
         {
            System.Console.Write(eskidizi+" ");
         }

        bool sayiBulundu = false;

       for( int i =0 ; i<dizi.Length ; i++)

         {

        if(girilenSayi==dizi[i]){
               
               sayiBulundu = true;
            System.Console.Write(" \n Girilen Sayi dizi de mevcuttur. \n  ");
               break;
               
        } 
     }

     if(!sayiBulundu) {

         Array.Resize(ref dizi,dizi.Length+1);
                dizi[dizi.Length-1]=girilenSayi;
               
            }
       
        
System.Console.Write(" \n");
          Array.Sort(dizi);
    System.Console.WriteLine("\nYeni Dizi : \n");
         foreach (int yenidizi in dizi)
         {
            System.Console.Write(yenidizi+" ");
         }

    }
}
