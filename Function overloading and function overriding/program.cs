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
            Console.WriteLine("First int method is: " + Sum(23, 45));
            Console.WriteLine("Second Float method is: " + Sum(53, 82.34f));
            Console.WriteLine("Third double method is: " + Sum(70.423, 91.532));

        }
    }
}