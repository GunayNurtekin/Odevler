namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
      

        Console.Write("Lütfen Bir Cümle Giriniz : ");
        string cumle = Console.ReadLine();

        string kucukharf = cumle.ToLower();
        string buyukharf = cumle.ToUpper();

        System.Console.WriteLine($"{kucukharf} \n{buyukharf}" );
    }
}
