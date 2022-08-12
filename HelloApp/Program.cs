using System;
using MyCalc;

namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Jenkins");
            Calc calc = new Calc();
            Console.WriteLine($"Sum = {calc.Add(20, 30)}");
            Console.WriteLine($"Multiply={calc.Multiply(20, 30)}");
            Console.ReadLine();
        }
    }
}
