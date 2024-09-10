namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // Klavyeden girilen 10 sayıyı bir diziye atayın. Bu sayılardan çift olanları for döngüsü kullanarak ayrı bir diziye aktarın. Ardından bu çift sayı dizisini küçükten büyüğe sıralayın.

        int [] sayilar = new int [10];
        int i ;

        for(i=0 ; i<sayilar.Length ; i++ ){

            Console.Write($"Lütfen {i+1}. Sayiyi Giriniz : ");
            sayilar[i]=Convert.ToInt32(Console.ReadLine());
        }
        
        int ciftSayiSayisi=0 ;

  for(i = 0 ; i < sayilar.Length ; i++)
        {
            if(sayilar[i] % 2 == 0)
            {
                ciftSayiSayisi++;
            }
        }

        int [] yenidizi = new int [ciftSayiSayisi];
        int index =0;

         for(i=0 ; i<sayilar.Length ; i++ )
         
         {

            if(sayilar[i]%2==0){
                
                yenidizi[index]=sayilar[i];
                index++;
            }

        }
System.Console.WriteLine("Girilen rakamlardan çift sayi olanlardan oluşan yeni dizimiz : \n");
        Array.Sort(yenidizi);

        foreach (int ciftsayilar in yenidizi)
        {
            System.Console.Write(ciftsayilar + " ");
        }
       

    }
}
