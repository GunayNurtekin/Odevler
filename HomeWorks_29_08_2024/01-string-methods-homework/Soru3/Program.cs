namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
      


           // Kullanıcıdan cümle alın
        Console.Write("Lütfen bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        // Kullanıcıdan aramak istediği kelimeyi alın
        Console.Write("Lütfen aramak istediğiniz kelimeyi giriniz: ");
        string kelime = Console.ReadLine();

        // Küçük harfe çevirerek karşılaştırma yap
        string cumleKucuk = cumle.ToLower();
        string kelimeKucuk = kelime.ToLower();

        // Cümleyi boşluk ve noktalama işaretleri ile böl
        string[] kelimeler = cumleKucuk.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Kelime sayacını başlat
        int kelimeSayisi = 0;

        // Kelime dizisinde aranan kelimenin sayısını bul
        foreach (string kelimeItem in kelimeler)
        {
            if (kelimeItem == kelimeKucuk)
            {
                kelimeSayisi++;
            }
        }

        // Sonucu ekrana yazdır
        Console.WriteLine($"\"{kelime}\" kelimesi cümlede {kelimeSayisi} kez geçiyor.");
    }
}

    

