using System.Net.Http.Headers;

namespace Soru1;




class Program
{
    static void Main(string[] args)
    {
        Aslan aslan1 = new Aslan("Aslan",4,"saldirgan") ;
        aslan1.MakeSound();

        Fil fil1 = new Fil ("Fil",10,"uzun kulak") ;
        fil1.MakeSound();

        Zürafa zürafa1 = new Zürafa ("Zürafa",5,"Kısa Kuyruk");
        zürafa1.MakeSound();
       
    }
}
