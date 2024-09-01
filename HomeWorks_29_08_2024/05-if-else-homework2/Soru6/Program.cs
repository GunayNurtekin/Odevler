namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıların manavdan almış oldukları ürünlerin kilogram değerlerine göre toplam tutarını ekrana yazdıran programı yazın.

//* Armut : 45,50 TL
//* Bamya : 81,40 TL
//* Domates : 45,00 TL
//* Muz: 65,00 TL
//* Patlıcan : 45,00 TL

        Console.Write("Kac Kilo Armut : ");
        int armut = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kac Kilo Bamya : ");
        int bamya = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kac Kilo Domates : ");
        int domates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kac Kilo Muz :");
        int muz = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kac Kilo Patlican :");
        int patlican = Convert.ToInt32(Console.ReadLine());

        double toplamtutar = (armut*45.5)+(bamya*81.4)+(domates*45)+(muz*65)+(patlican*45);

        System.Console.WriteLine($" {armut} kg armut \n {bamya} kg bamya \n {domates} kg domates \n {muz} kg muz \n {patlican} kg patlican \n toplam {toplamtutar} Tl");

    }
}
