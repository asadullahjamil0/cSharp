// using System;

// namespace accessModifiers
// {
//     class Car
//     {
//         // private string model = "Mercedes";
//         public string model = "Mercedes";
//         private int year = 2019;
//         public void setYear(int newYear)
//         {
//             year = newYear;

//         }
//         public int getYear()
//         {
//             return year;
//         }
//     }
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             Car myCar = new Car();
//             Console.WriteLine(myCar.model);
//             // We cannot access private members of class
//             // Console.WriteLine(myCar.year); 
//             myCar.setYear(2019);
//             Console.WriteLine(myCar.getYear());

//         }
//     }
// }