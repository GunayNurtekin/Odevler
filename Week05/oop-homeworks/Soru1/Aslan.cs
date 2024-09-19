namespace Soru1;

class Aslan : Animal
{
    public Aslan(string name, int age, string species) : base(name, age, species)
    {
    }


    public override void MakeSound()
    {
        System.Console.WriteLine($"{Species} bir tür olan ve {Age} yaşinda olan , {Name} kükredi ! ");
    }

}