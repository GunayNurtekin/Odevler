namespace Soru2;

class Program
{
    static void Main(string[] args)
    {

//Bir Vehicle (Taşıt) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
// Make (marka): Taşıtın markası
// Model (model): Taşıtın modeli
// Year (yıl): Taşıtın üretim yılı
// Bu temel sınıftan Car (Araba), Bicycle (Bisiklet) ve Motorcycle (Motosiklet) sınıflarını türetin. Her taşıt türüne özel bir özellik ekleyin (örneğin, Car için NumberOfDoors (Kapı Sayısı), Motorcycle için HasSidecar (Yan Sepet Var mı)).

    Car car1 = new Car("Renault","Clio",2004,4);
    car1.TellmeSomething();

    Bicycle bicycle = new Bicycle("Salcano","rider",2014,false);

    MotorCycle motorCycle = new MotorCycle("Kawasaki","jet",2018,90);
    
    }
}
