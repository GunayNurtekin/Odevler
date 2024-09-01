namespace Soru5;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan bir tarihin yılın kaçıncı günü olduğunu hesaplayan bir program yazın.

        Console.Write("Geçerli Formatta Bir Tarih Giriniz ( GG-AA-YYYY) = ");
        string tarih = Console.ReadLine();

        try {

            DateTime gecerlitarih = DateTime.Parse(tarih);
            int yilinGunu = gecerlitarih.DayOfYear;
            System.Console.WriteLine($"Yilin {yilinGunu}. Günü");

        } catch

        {
            System.Console.WriteLine("Geçerli bir tarih formati giriniz.");
        }
    }
}
