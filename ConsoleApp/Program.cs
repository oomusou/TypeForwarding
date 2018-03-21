using System;
using ClassLibrary1;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var object1 = new Class1();
            var result = object1.Sum(1, 1);
            Console.WriteLine(result);
        }
    }
}