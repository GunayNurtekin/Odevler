namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir karaktere göre (+, -, *, /, %) matematiksel işlemin adını yazdıran bir program yazın

        Console.Write("Lütfen bir karakter seçiniz (+, -, *, /, %) :  ");
        char islem = Char.Parse(Console.ReadLine());

        switch(islem){
            case '+' : System.Console.WriteLine("Toplama İşlemi"); break ;
            case '-' : System.Console.WriteLine("Çikarma İşlemi"); break ;
            case '*' : System.Console.WriteLine("Çarpma İşlemi"); break ;
            case '/' : System.Console.WriteLine("Bölme İşlemi"); break ;
            case '%' : System.Console.WriteLine("Mod Alma İşlemi"); break ;
            default : System.Console.WriteLine("Belirtilen işlemlerden birini seçiniz."); break;
        }
    }
}
