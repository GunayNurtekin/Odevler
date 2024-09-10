namespace Soru11;

class Program
{
    static void Main(string[] args)
    {
        // Klavyeden girilen bir cümlenin kelimelerini bir diziye aktarın. while döngüsü ile bu kelimeleri tersten ekrana yazdırın.

        
        System.Console.WriteLine("\n Bir Cümle Giriniz :  \n");
        string cumle = Console.ReadLine();

        string [] cumledizi= cumle.Split(" "); 

        Array.Reverse(cumledizi);

        int i =0;

        System.Console.WriteLine("\n Cümlenin Tersten Okunusu :  \n");  

    while(i<cumledizi.Length)
{
    System.Console.Write(cumledizi[i] + " ");
    i++;
}
       


    }
}
