using System;

namespace overloading
{

    public class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static float Sum(int x, float y)
        {
            return x + y;
        }
        static double Sum(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"We'll learn about function overloading");
            Console.WriteLine("First int method is: " + Sum(23, 45));
            Console.WriteLine("Second Float method is: " + Sum(53, 82.34f));
            Console.WriteLine("Third double method is: " + Sum(70.423, 91.532));
            Console.WriteLine($"We'll learn about function Overriding");

            Dog dog = new Dog();
            dog.speak();

            Cat cat = new Cat();
            cat.speak();

        }
        class Animal
        {
            public virtual void speak()
            {
                Console.WriteLine("Animal goes to *brrr*");
            }

        }
        class Dog : Animal
        {
            public override void speak()
            {
                Console.WriteLine($"The dog goes to *Woof*");
            }
        }
        class Cat : Animal
        {
            public override void speak()
            {
                Console.WriteLine($"The cat goes to *meow*");
            }
        }
    }
}