namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Alınan Para : ");
        int para = Convert.ToInt32(Console.ReadLine());

        if ( para==0 || para<1000) {

            double para20 = para*0.20;
            double para120 =para*1.20;

            System.Console.WriteLine($"Alinan paranın kdv tutarı {para20} TL , kdv ile birlikte toplam tutari {para120} Tl'dir. ");
        }else {
            double para8 = para*0.08;
            double para108 =para*1.08;
            System.Console.WriteLine($"Alinan paranın kdv tutarı {para8} TL , kdv ile birlikte toplam tutari {para108} Tl'dir. ");
        }
    }
}
