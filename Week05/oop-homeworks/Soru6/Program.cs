namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
//Bir Calculator (Hesap Makinesi) sınıfı oluşturun. Bu sınıf aşağıdaki işlemleri gerçekleştiren metodlar içermelidir:
// Add (Topla)
// Subtract (Çıkar)
// Multiply (Çarp)
// Divide (Böl)
// Bu sınıftan ScientificCalculator (Bilimsel Hesap Makinesi) türetin ve içine Sin (Sinüs), Cos (Kosinüs) gibi ekstra fonksiyonlar ekleyin.
    
    Calculator hesap = new Calculator();

    System.Console.WriteLine($"Toplama : 10 + 5 işleminin sonucu " + hesap.Add(10,5));
    System.Console.WriteLine($"Çıkarma : 10 + 5 işleminin sonucu " + hesap.Subtract(10,5));
    System.Console.WriteLine($"Çarpma  : 10 + 5 işleminin sonucu " + hesap.Multiply(10,5));
    System.Console.WriteLine($"Bölme   : 10 + 5 işleminin sonucu " + hesap.Divide(10,5));

    System.Console.WriteLine("\n");

     ScientificCalculator zorhesap = new ScientificCalculator();
    
    System.Console.WriteLine($"65 derece acinin Sinüsü : " + zorhesap.Sin(65));
    System.Console.WriteLine($"65 derece acinin Cosinüsü : " + zorhesap.Cos(65));
    System.Console.WriteLine($"65 derece acinin Tanjanti : " + zorhesap.Tan(65));
  
    
    }
}
