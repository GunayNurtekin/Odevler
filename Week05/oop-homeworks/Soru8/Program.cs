namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
// Bir Person (Kişi) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:

// Name (isim): Kişinin adı
// Age (yaş): Kişinin yaşı
// Bu sınıftan Teacher (Öğretmen) ve Student (Öğrenci) sınıflarını türetin. Teacher sınıfına SubjectTaught (Öğrettiği Konu), Student sınıfına ise GradeLevel (Sınıf Seviyesi) özelliğini ekleyin. Her iki sınıfa da AttendClass (Derse Katıl) metodunu ekleyin, ancak bu metod her sınıfta farklı çalışsın.
   
   
  Student s1 = new Student("Ahmet",7,2);
  s1.AttendClass();

  Teacher t1 = new Teacher("Mehmet",56,"Matematik");
  t1.AttendClass();
   
    }
}
