namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan üç sayıyı büyükten küçüğe sıralayan bir program yazın.
        
        Console.Write("1.Sayı: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2.Sayı: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("3.Sayı: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        if(sayi1>sayi2){

            if(sayi2>sayi3){
                System.Console.WriteLine($"{sayi1} en büyük , {sayi2} ortanca , {sayi3} en küçük sayidir");
            }else {
                System.Console.WriteLine($"{sayi1} en büyük , {sayi3} ortanca , {sayi2} en küçük sayidir");
            }
        }else if (sayi2>sayi3){
            if(sayi3>sayi1){
                System.Console.WriteLine($"{sayi2} en büyük , {sayi3} ortanca , {sayi1} en küçük sayidir");
            }else {
                System.Console.WriteLine($"{sayi2} en büyük , {sayi1} ortanca , {sayi3} en küçük sayidir");
            }
        }else {
            if(sayi1>sayi2){
                 System.Console.WriteLine($"{sayi3} en büyük , {sayi1} ortanca , {sayi2} en küçük sayidir");
            }else {
                System.Console.WriteLine($"{sayi3} en büyük , {sayi2} ortanca , {sayi1} en küçük sayidir");
            }
        }
    }
}
