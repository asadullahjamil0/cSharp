// using System;

// namespace polymorphism
// {
//     class A
//     {
//         int a = 10, b = 20;
//         public void add()
//         {
//             int sum = a + b;
//             Console.WriteLine("This is first add: " + sum);
//         }
//         public void add(int a, int b)
//         {
//             int sum = a + b;
//             Console.WriteLine("This is second add with parameters but same name: " + sum);
//         }
//         public void class_1()
//         {
//             Console.WriteLine("This is class A");
//         }
//     }
//     class B : A
//     {
//         public void class_1()
//         {
//             Console.WriteLine("This is class B");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             A addSum = new A();
//             addSum.add();
//             addSum.add(23, 67);
//             //Another example
//             // Now we will see another example of this
//             A class_A = new A();
//             class_A.class_1();
//             A class_B = new B();
//             class_B.class_1();

//         }
//     }
// }