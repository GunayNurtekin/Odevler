namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        
        // switch-case kullanarak 4 işlem yapabilen bir hesap makinesi yapınız.

        Console.Write("1.Sayi: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2.Sayi: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bir işlem seçiniz ( + - * /): ");

        char islem = Convert.ToChar(Console.ReadLine());

    double sonuc = 0;
        switch (islem) {

            case '+':

            sonuc = sayi1+sayi2;
            System.Console.WriteLine($"Sonuç : {sonuc }");
            break ;

            case '-':

            sonuc = sayi1-sayi2;
            System.Console.WriteLine($"Sonuç : {sonuc }");
            break ;

            case '*':

            sonuc = sayi1*sayi2;
            System.Console.WriteLine($"Sonuç : {sonuc }");
            break ;

            case '/':

            if(sayi2!=0)
            {
            
            sonuc = sayi1/sayi2;
            System.Console.WriteLine($"Sonuç : {sonuc }");
         

            }else {
                System.Console.WriteLine("Sifira Bölme işlemi Yapamazsiniz.");
            }
break;
           
        default:
        System.Console.WriteLine("Geçersiz işlem seçildi.");
        break;
}
    }
}
