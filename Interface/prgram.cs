using System;

namespace Interface
{
    public interface IAnimal
    {
        public void animalSound();

    }
    class Lion : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("Animal is Roaring!");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Lion myLion = new Lion();
            myLion.animalSound();

        }
    }

}