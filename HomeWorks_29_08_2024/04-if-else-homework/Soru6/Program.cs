using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Soru6;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir notun aşağıdaki tabloya göre harf karşılığını veren bir program yazın.

        Console.Write("Öğrenci Notunu Giriniz : ");
        int not = Convert.ToInt32(Console.ReadLine());

      
        if(not>100){
            System.Console.WriteLine("0 ile 100 arasinda bir değer giriniz.");
        }else if(not==100 || not>89){
                System.Console.WriteLine("Öğrenci Notu : AA");
            }else if(not==89 || not>84){
                System.Console.WriteLine("Öğrenci Notu : BA");
            }else if(not==84 || not>79){
                System.Console.WriteLine("Öğrenci Notu : BB");
            }else if(not==79 || not>69){
                System.Console.WriteLine("Öğrenci Notu : CB");
            }else if(not==69 || not>59){
                System.Console.WriteLine("Öğrenci Notu : CC");
            }else if(not==59 || not>54){
                System.Console.WriteLine("Öğrenci Notu : DC");
            }else if(not==54 || not>50){
                System.Console.WriteLine("Öğrenci Notu : DD");
            }else if(not==49 || not>39){
                System.Console.WriteLine("Öğrenci Notu : FD");
            }else{
                System.Console.WriteLine("Öğrenci Notu : FF");
        }
  
}
}