namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan bir saati, 12 saat formatından 24 saat formatına (veya tam tersi) çeviren bir program yazın.

        Console.Write("Bir saat giriniz : ");
        string saat12= Console.ReadLine();

        DateTime saat24 = DateTime.Parse(saat12);

        System.Console.WriteLine("24 Saat Formatı  "+ saat24.ToString("HH:mm")); 
    }
}
