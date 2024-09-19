namespace Soru1;

class Fil : Animal
{
    public Fil(string name, int age, string species) : base(name, age, species)
    {
    }

    public override void MakeSound()
    {
        System.Console.WriteLine($"{Species} bir tür olan ve {Age} yaşinda olan , {Name} Tiiiiii ! diye bağirdi ! ");
    }

}