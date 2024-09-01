namespace Soru2;

class Program
{
    static void Main(string[] args)
    {

        // Üç kenar uzunluğunu kullanıcıdan aldığınız üçgenin alanını heron formülü ile hesaplayan programı yazınız.

        Console.Write("1.Kenar Uzuluğu : ");
        double kenara= Convert.ToDouble(Console.ReadLine());

         Console.Write("2.Kenar Uzuluğu : ");
        double kenarb= Convert.ToDouble(Console.ReadLine());

         Console.Write("3.Kenar Uzuluğu : ");
        double kenarc= Convert.ToDouble(Console.ReadLine());

        if (kenara+kenarb>kenarc && kenarb+kenarc>kenara && kenara+kenarc>kenarb)
        {
            double yaricevre = (kenara+kenarb+kenarc)/2;
            double alan = Math.Sqrt(yaricevre*(yaricevre-kenara)*(yaricevre-kenarb)*(yaricevre-kenarc));

            System.Console.WriteLine($"Kenar uzunluklari belirtilen üçgen'in heron formülüne göre alani : {alan} dir.");



        }else{
            System.Console.WriteLine("Girilen Kenar Ölçüleleri ile Üçgen Çizilemez.");
        }
    }
}
