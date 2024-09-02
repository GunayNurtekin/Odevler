namespace Soru5;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir sayıya göre (1-4 arası) mevsim adını yazdıran bir program yazın.

        Console.Write("Mevsim için bir numara giriniz. (1-4 Arasinda ): ");
        byte sayi = Convert.ToByte(Console.ReadLine());

        switch(sayi){
            case 1: System.Console.WriteLine("Kiş");break;
            case 2: System.Console.WriteLine("İlk Bahar");break;
            case 3: System.Console.WriteLine("Yaz");break;
            case 4: System.Console.WriteLine("Son Bahar");break;

            default : System.Console.WriteLine("Geçerli Bir Sayi Girmediniz. Lütfen 1 ile 4 Arasinda Bir Sayi Giriniz.");break;
        }
    }
}
