namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
    // Klavyeden girilen bir sayının, 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde olup olmadığını kontrol eden bir algoritma yazın. 
    // Eğer sayı dizide varsa, sayının dizideki yerini ve tekrar sayısını ekrana yazdırın.

// Kullanicadan sayi alalim
    Console.Write("Aradiginiz Sayiyi Giriniz : ");
    int arananSayi = Convert.ToInt32(Console.ReadLine());

// Rastgele 100 sayi ürettirelim

    int [] rastgeleSayilar = new int [100];
    Random rnd = new Random();

    for(int i=0; i<rastgeleSayilar.Length ;i++)
    {

    rastgeleSayilar [i] = rnd.Next(0,101);

    }
     System.Console.WriteLine("Oluşturulan Sayi Dizisi : \n");
    foreach (int sayi in rastgeleSayilar)
    {
        System.Console.Write(sayi+ " ");
    }
   
    System.Console.WriteLine("");

    // Aranan Sayinin Dizi de olup olmadığına bakalim.

    bool sayiVar = false;   
    int tekrarsayisi =0;


    for(int i=0; i<rastgeleSayilar.Length ;i++){

        if(arananSayi==rastgeleSayilar[i]){

            if(!sayiVar){
                System.Console.WriteLine($"Aranan {arananSayi} değeri. Sayi dizimizde mevcuttur. \n" );
                sayiVar = true;
            }

            tekrarsayisi++;
        }
    }
        
        // kacinci kez tekrar ettiğini bulalim

    if (sayiVar){
        System.Console.WriteLine($"Aranan {arananSayi} değeri, Sayi dizimizde mevcuttur. Bu sayidan {tekrarsayisi} adet mevcuttur. ");
    }
else { System.Console.WriteLine($"Aranan {arananSayi} değeri, sayi dizimizde mevcut değildir. ");}
    


    }
}
