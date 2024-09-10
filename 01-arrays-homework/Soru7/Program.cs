namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // 50 elemanlı rastgele değerlerden oluşan bir tam sayı dizisindeki tüm çift sayıları toplayan ve bu toplamı ekrana 
        //yazdıran bir program yazın. foreach döngüsü kullanarak bu işlemi gerçekleştirin.

        // Önce 50 adet rastegele sayi oluşturalim.

        int [] sayilar = new int [50];
        Random rnd = new Random();

        for(int i = 0; i<sayilar.Length; i++){

            sayilar[i]=rnd.Next(0,101);

        }

            System.Console.Write($"Rastgele üretilen Sayi Dizisi : \n");

        foreach (int say in sayilar)
        {
            System.Console.Write(say+" ");
        }

    // Bu sayilar arasinda cift sayi olanlari toplayalim.

    int [] ciftsayi = new int [50];
    int ciftsayitoplam=0;

     for(int i = 0; i<sayilar.Length; i++){

            if(sayilar[i]%2==0){

                ciftsayi[i]=sayilar[i];
                ciftsayitoplam +=ciftsayi[i];
            }

        }


    System.Console.Write(" \n");
    System.Console.Write($"Çift Sayi Dizisi : \n");
        foreach (int cift in ciftsayi)
        {
            if(cift>0){
            System.Console.Write(cift+" ");
            }
        }
        
        // Çift Sayilarin toplamini ekrana yazdiralim..
        
        System.Console.Write(" \n");
        System.Console.WriteLine($"Bu sayi dizisindeki cift sayilarin toplami : {ciftsayitoplam}");
}}
