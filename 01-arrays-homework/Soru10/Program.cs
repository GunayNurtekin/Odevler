namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        // 10 elemanlı bir dizi oluşturun ve bu dizinin elemanlarını bir başka diziye ters sırada kopyalayın. İlk dizideki sıralama değişmeyecek, sadece ikinci dizideki sıralama ters olacak.
    
    int [] dizi = new int [10];
    Random rnd = new Random ();

  for (int i = 0; i < dizi.Length; i++)
    {
        dizi[i]=rnd.Next(0,100);
    }

    System.Console.WriteLine("\n Oluşturulan dizi : \n");
    foreach (int d in dizi)
    {
        System.Console.Write(d+ " ");
    }
    
    int [] kopyaDizi = new int [10];
    
    Array.Copy(dizi,kopyaDizi,dizi.Length);
    Array.Reverse(kopyaDizi);

     System.Console.WriteLine("\n Kopyalanan dizi : \n");
    foreach (int k in kopyaDizi)
    {
        System.Console.Write(k+ " ");
    }


    }
}
