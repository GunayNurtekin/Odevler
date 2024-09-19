namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        

// Bir Employee (Çalışan) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:

// Name (isim): Çalışanın adı
// Id (kimlik numarası): Çalışanın kimlik numarası
// Salary (maaş): Çalışanın maaşı
// Employee sınıfından Manager (Yönetici), Developer (Geliştirici) ve Intern (Stajyer) sınıflarını türetin. Manager sınıfına ek olarak NumberOfTeams (Takım Sayısı) özelliğini, Developer sınıfına ise ProgrammingLanguage (Programlama Dili) özelliğini ekleyin.


    Manager manager1 = new Manager ("Mehmet",2,55000,4);
    manager1.TellmeSomething();
    Developer developer1 = new Developer("Ahmet",4,45000,"Asp.Net");
    developer1.TellmeSomething();

    Intern intern1 = new Intern ("Ayse",85,17002);
    intern1.TellmeSomething();


    }
}
