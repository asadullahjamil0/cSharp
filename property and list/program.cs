using System;
using System.Collections.Generic;

namespace Property
{
    class MyClass
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Name = "AsadUllah Jamil";
            Console.WriteLine(obj.Name);

            //We'll learn about list now 
            Console.WriteLine($"We'll learn about list now in c#");

            List<string> food = new List<string>(10);
            food.Add("Pizza");
            food.Add("Burger");
            food.Add("Shuwarma");
            food.Add("Hot wings");
            //Different methods to manipulate list
            // food.Remove("Burger");
            // food.Sort();
            // food.Clear();
            // Console.WriteLine(food.Contains("Pizza"));
            // Console.WriteLine(food.IndexOf("Hot wings"));
            // Console.WriteLine(food.LastIndexOf("Hot wings"));
            // Console.WriteLine(food.Count());
            // food.Insert(1, "Biryani");
            // Console.WriteLine(food.Capacity);
            // food.Reverse();

            Console.WriteLine("Elements in our list are\n");
            int p = 1;
            foreach (string item in food)
            {
                Console.WriteLine("At position " + p + ":");
                Console.WriteLine(item);
                p++;
            }
        }

    }
}