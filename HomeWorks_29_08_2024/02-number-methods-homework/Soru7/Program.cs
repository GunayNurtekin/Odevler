namespace Soru7;

class Program
{

    //Kullanıcıdan alınan bir açının (derece cinsinden) radyan cinsinden değerini hesaplayan bir program yazın.
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir açının (derece cinsinden) radyan cinsinden değerini hesaplayan bir program yazın.

        Console.Write("Bir aci giriniz : ");
        double aci = Convert.ToDouble(Console.ReadLine());

        double radyan = aci*(Math.PI/180);

        System.Console.WriteLine($"Girilen {aci} açı değerinin radyan cinsinden değeri: {radyan}");
    }
}
