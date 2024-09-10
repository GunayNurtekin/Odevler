namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // 10 elemanlı rastgele değerlerden oluşan bir dizideki tüm pozitif sayıları ve negatif sayıları ayrı dizilere ayıran ve 
        //her iki diziyi de ekrana yazdıran bir program yazın. İşlemi gerçekleştirmek için while döngüsü kullanın.

        Random rnd = new Random();
        int[] sayilar = new int[10];

           for (int j = 0; j < sayilar.Length; j++)
        {
            sayilar[j] = rnd.Next(-100, 100); // -100 ile 100 arasında rastgele sayılar
        }

        foreach (int sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine("\n");
       

        int [] pozitifSayilar = new int [10];

        int [] negatifSayilar = new int [10];

        int pozitifSayac = 0;

        int negatifSayac = 0;

        int i = 0;

        while(i<sayilar.Length){

            if(sayilar[i]>0){

                pozitifSayilar[pozitifSayac]=sayilar[i];
                pozitifSayac++;

            }else if (sayilar[i]<0){

                negatifSayilar[negatifSayac]=sayilar[i];
                negatifSayac++;

            }

            i++;

            

        }

        System.Console.WriteLine("Pozitif Sayilar : \n");
        for(i=0; i<pozitifSayac ; i++ ){
            System.Console.Write(pozitifSayilar[i]+" ");
            }

         Console.WriteLine("\n");
        System.Console.WriteLine("Negatif Sayilar : \n");
        for(i=0; i<negatifSayac ; i++ ){
            System.Console.Write(negatifSayilar[i]+" ");
        } Console.WriteLine("\n");
        }

    }

