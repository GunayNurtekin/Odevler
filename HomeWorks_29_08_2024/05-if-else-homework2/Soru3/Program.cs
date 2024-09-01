namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        //Gidilen mesafeye (KM) göre taksimetre tutarını ekrana yazdıran programı yazın.

//Parametreler
//Taksimetre açılış ücreti 30 TL'dir.
//Taksimetre KM başına ücret 20 TL'dir.
//Minimum ödenecek tutar 100 TL'dir. Örneğin 2 km gidildiğinde 90 TL tutar ama yine de 100 TL alınacaktır.

        Console.Write("Gidilen KM Gir : ");
        double km = Convert.ToDouble(Console.ReadLine());

        int acilis =30;

        if (km >3.5 ){
            double gidilenkmucret=km*20;
            double toplamucret =gidilenkmucret+acilis;
            System.Console.WriteLine($"Gidilen toplam Km ye göre ödenecek olan Tutar: {toplamucret} Tl dir.");
        }else
        {System.Console.WriteLine("İndi bindi ücreti geçerlidir. 100 TL dir.");}
    }
}
