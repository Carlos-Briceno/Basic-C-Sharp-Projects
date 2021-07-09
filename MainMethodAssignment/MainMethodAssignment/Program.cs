using System;
using System.Collections.Generic;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();

            // prints out the sum of 24 / 4
            Console.WriteLine(methods.myMethod1(24));

            // prints out the sum of 5.5 % 10
            Console.WriteLine(methods.myMethod2(5.5m));

            // prints out 33 + 1000
            Console.WriteLine(methods.myMethod3("33"));

            Console.ReadLine();
        }
    }
}
