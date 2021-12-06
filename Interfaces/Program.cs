/* Interfaces are VERY similar to an abstract class. An Interface can't be implemented
on its own. Must be inherited/extended. */

/* abstract class Abstract
{
    private string AbstractString = "I am a string.";
} */

//Interface
interface IAnimal
{
    void animalSound();
}

interface IMammal
{
    void warmBlooded();
}

class Pig : IAnimal , IMammal
{
    public void animalSound()
    {
        Console.WriteLine("Oink!");
    }

    public void warmBlooded()
    {
        Console.WriteLine("Toasty");
    }
    
}
class Program
{
    public static void Main()
    {
        Pig myPig = new Pig();
        myPig.animalSound();     
        myPig.warmBlooded();           
    }
}