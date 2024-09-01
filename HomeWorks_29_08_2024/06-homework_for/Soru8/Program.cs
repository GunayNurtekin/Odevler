namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bir sayı alarak, bu sayıya kadar olan Fibonacci serisini hesaplayan bir program yazın.

        Console.Write("Bir sayı girin: ");
        int sinir = Convert.ToInt32(Console.ReadLine());

        int a = 0; // Fibonacci serisinin ilk elemanı
        int b = 1; // Fibonacci serisinin ikinci elemanı

        Console.WriteLine("Fibonacci serisi:");
        Console.Write(a + " " + b + " "); // İlk iki elemanı yazdır

        int c; // Fibonacci serisinde bir sonraki elemanı tutmak için değişken

        while (true)
        {
            c = a + b; // Sonraki Fibonacci sayısı
            if (c > sinir) break; // Eğer hesaplanan sayı sınırı geçerse döngüden çık

            Console.Write(c + " "); // Fibonacci sayısını yazdır
            a = b; // a'yı bir sonraki eleman olarak güncelle
            b = c; // b'yi bir sonraki eleman olarak güncelle
        }

        Console.WriteLine(); // Yeni satıra geç
    }
}
