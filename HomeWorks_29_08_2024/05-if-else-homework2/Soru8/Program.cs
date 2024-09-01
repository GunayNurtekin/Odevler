namespace Soru8;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alından doğum tarihine göre kişinin Çin Zodyağını hesaplayan programı yazınız.

        Console.Write("Doğum Yilinizi Giriniz : ");
        int yil=Convert.ToInt32(Console.ReadLine());

        int sonuc = yil%12;

     if(sonuc==0){
        string burc="Maymun";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==1){
        string burc="Horoz";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==2){
        string burc="Köpek";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==3){
        string burc="Domuz";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==4){
        string burc="Fare";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==5){
        string burc="Öküz";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==6){
        string burc="Kaplan";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==7){
        string burc="Tavşan";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==8){
        string burc="Ejderha";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==9){
        string burc="Yilan";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==10){
        string burc="At";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }else if(sonuc==11){
        string burc="Koyun";
        System.Console.WriteLine($"Burcunuz : {burc}");
     }






      }
    }

