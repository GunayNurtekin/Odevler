namespace Soru4;

class Program
{
    static void Main(string[] args)
    {

        //Yarı çapını kullanıcıdan aldığınız dairenin alanını ve çevresini hesaplayan programı yazın.
        //Dairenin çevresi : 2*pi*r
        //Dairenin Alanı   : pi.r2
        
        
        Console.Write("Daire yari capini giriniz : ");
        double r = Convert.ToDouble(Console.ReadLine());

        double cevre= 2*Math.PI*r;
        double yuvarlacevre = Math.Round(cevre);

        double alan = Math.PI*Math.Pow(r,2);
        double yuvarlaalan = Math.Round(alan);

        System.Console.WriteLine($"Yaricapini girdiğiniz alanin cevresi : {yuvarlacevre} , alani {yuvarlaalan} dir.");
    }
}
