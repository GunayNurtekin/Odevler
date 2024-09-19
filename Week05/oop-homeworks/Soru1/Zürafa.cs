namespace Soru1;

class Zürafa : Animal
{
    public Zürafa(string name, int age, string species) : base(name, age, species)
    {
    }


    public override void MakeSound()
    {
        System.Console.WriteLine($"{Species} bir tür olan ve {Age} yaşinda olan , {Name} ses çikardi!!! ");
    }

}