namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        // Bir Event (Etkinlik) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
        // Name (isim): Etkinlik adı
        // Date (tarih): Etkinlik tarihi
        // Location (yer): Etkinlik yeri
        // Bu sınıftan Meeting (Toplantı), Birthday (Doğum Günü) ve Task (Görev) gibi farklı etkinlik sınıfları türetin. Her bir etkinlik türüne özel bir metod ekleyin (örneğin, Task için MarkAsComplete (Tamamlandı Olarak İşaretle)).


       

        Birthday brt = new Birthday("Atlas", "22.09.2024","Okyanus Cafe" );
        brt.congratulatoryMessage();

        Meeting meet = new Meeting("Ahmet" , "17.09.2024", " Pera Hotel");
        meet.MeetingMessage();

        Task task1 = new Task("Sevilay","21.09.2024","Meydan Cafe");
        task1.MarkAsComplete();
    
    }
}
