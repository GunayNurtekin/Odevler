namespace Soru5;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan boy ve kilo değerlerine göre aşağıdaki formülü kullanarak kullanıcının "Vücut Kitle İndeks" değerini hesaplayıp ekrana yazdırın.
       
        // Vücut kitle indeksi, vücut ağırlığının boy uzunluğunun karesine bölünmesiyle (kg/m²) hesaplanır.
       
        Console.Write("Kilonuzu Giriniz ( kg ): ");
        double kilo = Convert.ToDouble(Console.ReadLine());

         Console.Write("Boyunuzu Giriniz ( cm ): ");
        double boy = Convert.ToDouble(Console.ReadLine());
        double boym = boy/100;

        double vki = kilo/Math.Pow(boym,2);

        System.Console.WriteLine($"Girdiğiniz bilgilere göre Vücut Kitle İndeksiniz : {vki}");
    }
}
