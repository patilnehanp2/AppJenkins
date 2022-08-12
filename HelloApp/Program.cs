using System;
using MyCalc;


namespace HelloApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Class1 calc = new Class1();
            Console.WriteLine($"Sum = {calc.Add(20, 30)}");
            Console.WriteLine($"Multiply={calc.Multi(20, 30)}");
            Console.ReadLine();
        }
    }
}
