namespace Soru9;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan alınan bir tarihin, başka bir kullanıcıdan alınan tarihten önce mi, sonra mı yoksa aynı mı olduğunu kontrol eden bir program yazın.

        Console.Write("İlk Tarihi Yaziniz(GG.AA.YYYY) : ");
        string tarih1 = Console.ReadLine();

        try {
            DateTime tarih1Onay = DateTime.Parse(tarih1);
        }catch
        {
            System.Console.WriteLine("Geçerli Formatta Tarih Giriniz");
        }

Console.Write("İkinci Tarihi Yaziniz(GG.AA.YYYY) : ");
        string tarih2 = Console.ReadLine();

        try {
            DateTime tarih2Onay = DateTime.Parse(tarih2);
            
        }catch
        {
            System.Console.WriteLine("Geçerli Formatta Tarih Giriniz");
        }

        DateTime tarih1date = Convert.ToDateTime(tarih1);
        DateTime tarih2date = Convert.ToDateTime(tarih2);

int karsilastirma = DateTime.Compare(tarih1date,tarih2date);

if(karsilastirma<0)
{
    System.Console.WriteLine($"Girilen 1.Tarih , 2. Tarihten daha önce dir.");
}else if (karsilastirma==0)

{
System.Console.WriteLine($"Girilen 1.Tarih ile 2. Tarih aynidir.");

}if (karsilastirma>0) {
    System.Console.WriteLine($"Girilen 1.Tarih , 2. Tarih ten sonradir.");
}

    }
}
