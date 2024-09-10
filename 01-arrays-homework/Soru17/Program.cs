namespace Soru17;

class Program
{
    static void Main(string[] args)
    {
        // Bir dizideki en büyük iki sayıyı bulan bir program yazın. Bu programı bir for döngüsü ile yazın, 
        //ancak aynı sayının iki defa en büyük olarak seçilmesine izin vermeyin.

        int [] sayilar = new int [10];
        Random rnd = new Random ();

        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i]=rnd.Next(0,100);
        }

        System.Console.WriteLine("Rastgele Sayi Dizisi : \n");
        foreach (int s in sayilar)
        {
          System.Console.Write(s+" ");  
        }

        int enBuyuk =0;
        int ikinciBuyuk = 0;

        for (int i = 0; i < sayilar.Length; i++)
        {
            if(sayilar[i]>enBuyuk){
                enBuyuk=sayilar[i];
            }
        }

        for (int i = 0; i < sayilar.Length; i++)
        {
            if(sayilar[i] > ikinciBuyuk && sayilar[i] != enBuyuk){
                
                ikinciBuyuk = sayilar[i];
            }
        }

        System.Console.WriteLine($"\nDizideki en büyük sayi : {enBuyuk} \nDizideki ikinci büyük sayi : {ikinciBuyuk}" );
    }
}
