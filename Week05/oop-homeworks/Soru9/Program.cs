namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
// Bir Account (Hesap) temel sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:

// AccountNumber (Hesap Numarası): Hesap numarası
// Balance (Bakiye): Hesap bakiyesi
// Bu sınıftan SavingsAccount (Tasarruf Hesabı) ve CheckingAccount (Vadesiz Hesap) sınıflarını türetin. Her hesap türüne özgü işlemler (örneğin, CheckingAccount için WriteCheck (Çek Yaz)) ekleyin.
    
    CheckingAccount cek = new CheckingAccount(54651651,35000);
    cek.WriteCheck();

    SavingsAccount tasarruf = new SavingsAccount(54321218,20000);
    tasarruf.AddMoney();
    
    }
}
