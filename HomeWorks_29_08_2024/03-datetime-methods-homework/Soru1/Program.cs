namespace Soru1;

class Program
{
    static void Main(string[] args)
    {  //Kullanıcıdan alınan bir tarihin haftanın hangi günü olduğunu bulan bir program yazın.

        Console.Write("(GG-AA-YYYY formatında) Bir Tarih Giriniz : ");
       string girilenTarih = Console.ReadLine();

       try{

            DateTime tarih = DateTime.Parse(girilenTarih);
           
           string gun = tarih.ToString("dddd");
           System.Console.WriteLine($"Girdiginiz tarih {gun} günüdür. ");


       }catch{

        System.Console.WriteLine("Geçersiz bir tarih formatı girdiniz. Lütfen GG-AA-YYYY formatında olarak giriniz. ");
       }
     
    
    }
}
