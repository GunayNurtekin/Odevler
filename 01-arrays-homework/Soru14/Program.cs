namespace Soru14;

class Program
{
    static void Main(string[] args)
    {
        //20 elemanlı bir dizi oluşturun. Bu dizideki elemanların 3’e bölünebilenlerin toplamını bulan bir algoritma yazın. 
        //Sonucu ekrana yazdırırken her 5. elemandan sonra bir boşluk bırakın.

        int [] dizi = new int [20];
        Random rnd = new Random();
        
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i]=rnd.Next(0,100);
        }
  
        System.Console.Write("\n 20 Elemanli Dizi : \n");
        foreach (int d in dizi)
        {
            System.Console.Write(d+" ");
        }

        int [] ucebolunenler = new int [20];
        int ucebolunensayisi = 0;
        int ucebolunentoplam = 0;

        for (int i = 0; i < dizi.Length; i++)
        {
            if(dizi[i]%3==0){

                ucebolunenler[i]=dizi[i];
                ucebolunentoplam +=dizi[i];
                ucebolunensayisi ++;
            }
        }

       


        System.Console.Write("\n 3e bolunenler : \n");
        foreach (int u in ucebolunenler)
        {
                System.Console.Write(u+" " );
       }
            System.Console.Write($"\n 3 e bölünebilen toplam {ucebolunensayisi} adet sayi vardir. Bölünenlerin toplami : {ucebolunentoplam} \n");
        }
    }

