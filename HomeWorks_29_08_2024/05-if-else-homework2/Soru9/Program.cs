namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcının girdiği yılın artık yıl olup olmadığını tespit edip ekrana yazdıran programı hazırlayınız.
        Console.Write("Bir Yil Giriniz : ");
        int yil = Convert.ToInt32(Console.ReadLine());

        if ((yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0))
        {
            Console.WriteLine($"{yil} artık bir yıldır.");
        }
        else
        {
            Console.WriteLine($"{yil} artık bir yıl değildir.");
        }
    }
}
