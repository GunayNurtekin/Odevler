namespace Soru15;

class Program
{
    static void Main(string[] args)
    {
        //Bir dizideki elemanları küçükten büyüğe sıralayan bir algoritma yazın. Ancak sıralama sırasında sadece tek sayılar 
        //sıralanmalı, çift sayılar yerlerinde kalmalıdır.

        int [] dizi = new int [10];
        Random rnd = new Random();
        
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i]=rnd.Next(0,50);
        }
  
        System.Console.Write("\n 10 Elemanli Dizi : \n");
        foreach (int d in dizi)
        {
            System.Console.Write(d+" ");
        }

        int [] teksayilar = new int [dizi.Length];
        int  teksayilarsayac =0;

        for (int i = 0; i < dizi.Length; i++)
        {
            if(dizi[i]%2!=0){
                teksayilar[teksayilarsayac]=dizi[i];
                teksayilarsayac ++;
            }
        }

        Array.Sort(teksayilar,0,teksayilarsayac);

         int tekIndex=0;
        for (int i = 0; i < dizi.Length; i++)
        {
             if (dizi[i] % 2 != 0)
                {
                    dizi[i] = teksayilar[tekIndex];
                    tekIndex++;
                }
        }
        System.Console.WriteLine("\n");
        System.Console.WriteLine("\n Tek sayilar siralanmiş dizi :");
        foreach (int sirali in dizi)
        {
            System.Console.Write(sirali+ " ");
        }
        
    }
}
