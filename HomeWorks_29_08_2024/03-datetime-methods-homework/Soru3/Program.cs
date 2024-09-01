namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan bir tarihe belirli bir gün sayısı ekleyerek yeni tarihi bulan bir program yazın.
        
         Console.Write("(GG-AA-YYYY formatında) Bir Tarih Giriniz : ");
         string girilenTarih = Console.ReadLine();

         Console.Write("Eklenecek Gün Sayisi: ");
         int gunSayisi ;


        if(int.TryParse(Console.ReadLine(),out gunSayisi))
        
        {

            try{
        DateTime tarih = DateTime.Parse(girilenTarih);
        DateTime yenitarih = tarih.AddDays(gunSayisi);
        System.Console.WriteLine($"Yeni Tarih : {yenitarih}");

        } catch {

            System.Console.WriteLine("Geçerli bir tarih formati yaziniz");
        }

        }else
        System.Console.WriteLine("Gün sayisini lütfen tam sayi olacak şekilde giriniz.");
       
    }
}
