using System;
using System.Dynamic;

namespace encapsulation
{
    class demoEncap
    {
        private string studentName;
        private int age;
        public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    class Program
    {
        static public void Main()
        {
            demoEncap obj = new demoEncap();
            obj.Name = "AsadUllah Jamil";
            obj.Age = 23;
            Console.WriteLine("My name is " + obj.Name);
            Console.WriteLine("My Age is " + obj.Age);

        }
    }
}