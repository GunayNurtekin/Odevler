namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
    //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde tekrar eden elemanları bulan bir program yazın. 
    // Diziyi tararken, elemanların hangi pozisyonlarda(kaçıncı indexte) tekrarlandığını ekrana yazdırın. 
    // Bu işlemi hem for hem de foreach döngüleri ile gerçekleştirin.


    Random rnd = new Random();

    int [] Sayilar =  new int [100];

    int i = 0;

    for(i=0; i<Sayilar.Length ;i++){

        Sayilar[i]=rnd.Next(0,100);

    }
    System.Console.WriteLine("Oluşturulan Sayi Dizisi : \n");
    foreach (int sayi in Sayilar)
    {
        System.Console.Write(sayi+ " ");
    }
    System.Console.WriteLine("\n");
     System.Console.WriteLine("Tekrar Eden Değerler ( For Döngüsü ile Tespit Edilenler) : \n");
    for ( i=0 ; i<Sayilar.Length ; i++){

        for ( int j = i+1 ; j<Sayilar.Length ; j++){

            if ( Sayilar[i]==Sayilar[j]){
                System.Console.WriteLine($"{Sayilar[i]} değeri hem {i} indeksinde hem de {j} indeksinde tekrar etmektedir.");
            }
        }
    }

    System.Console.WriteLine("\n");
     System.Console.WriteLine("Tekrar Eden Değerler ( Foreach Döngüsü ile Tespit Edilenler) : \n");


    }
}
