namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen Bir Cümle Giriniz : ");
        string cumle = Console.ReadLine();

        string kesilmisCumle = cumle.Trim();
    System.Console.WriteLine($"{cumle} cümlesinin yeni hali : {kesilmisCumle}");
    }
}
