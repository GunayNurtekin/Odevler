namespace cevap01;

class Program
{
    static void Main(string[] args)

    {

        Console.Write("Lütfen Bir Cümle Giriniz:");

        string cumle = Console.ReadLine();

        char ayir =' ';

        string [] kelimeler =cumle.Split(ayir);

        int kelimesayisi = Convert.ToInt32(kelimeler.Count());

        System.Console.WriteLine($"Bu cümledeki kelime sayisi : {kelimesayisi}");

    }
}
