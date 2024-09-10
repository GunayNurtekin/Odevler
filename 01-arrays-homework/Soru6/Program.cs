namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en büyük ve en küçük sayıyı bulan programı yazın.

        // Rastgele 100 elemanlı dizi oluşturalım.

        int [] sayilar = new int [100];

        Random rnd = new Random();

        for(int i = 0; i<sayilar.Length ; i++){

            sayilar [i] = rnd.Next(0,101);
        }

        System.Console.WriteLine("Oluşturulan Sayi Dizisi : \n");
        foreach (int sayiliste in sayilar)
        {
            System.Console.Write(sayiliste+" ");
        }

        int min = sayilar.Min();

        int max = sayilar.Max();
System.Console.WriteLine("\n");
        System.Console.WriteLine($"Rastgele oluşan sayi dizisinde en büyük değer : {max} , en küçük değer ise {min} dir. ");
    }
}
