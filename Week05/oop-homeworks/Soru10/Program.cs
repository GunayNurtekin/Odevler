namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
//Bir Character (Karakter) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
// Name (isim): Karakter adı
// Health (sağlık): Karakterin sağlığı
// Bu sınıftan Warrior (Savaşçı), Mage (Büyücü) ve Archer (Okçular) sınıflarını türetin. Her türemiş sınıfa spesifik saldırı yetenekleri ekleyin (örneğin, Warrior için SwordAttack (Kılıç Saldırısı), Mage için CastSpell (Büyü Atma)).
   
   
   Warrior savasci = new Warrior("Conan" , 100 ,"Kilic Saldirisi");
   savasci.Attacking();

   Mage buyucu = new Mage ("Cadi",80,"Büyü Atma,");
   buyucu.Attacking();
   
   Archer okcu = new Archer ("Elf",70,"Yanar Döner Ok");
   okcu.Attacking();
   
    }
}
