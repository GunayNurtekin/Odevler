using System.Runtime;

namespace Soru8;

class Program
{
    static void Main(string[] args)
    {

        // Şu anki tarihin ay adını tam olarak yazdıran bir program yazın (örneğin, "Ağustos").

        DateTime tarihBuAy =DateTime.Now;

        int ay =tarihBuAy.Month;
        

        if (ay==1){
System.Console.WriteLine("Ocak");
        }else if (ay==2) {
System.Console.WriteLine("Şubat");
        }else if (ay==3) {
System.Console.WriteLine("Mart");
        }else if (ay==4) {
System.Console.WriteLine("Nisan");
        }else if (ay==5) {
System.Console.WriteLine("Mayıs");
        }else if (ay==6) {
System.Console.WriteLine("Haziran");
        }else if (ay==7) {
System.Console.WriteLine("Temmuz");
        }else if (ay==8) {
System.Console.WriteLine("Ağustos");
        }else if (ay==9) {
System.Console.WriteLine("Eylül");
        }else if (ay==10) {
System.Console.WriteLine("Ekim");
        }else if (ay==11) {
System.Console.WriteLine("Kasım");
        }else   {
System.Console.WriteLine("Aralık");
        }
    }
}
