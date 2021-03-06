using System;
using System.Collections.Generic;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Method method = new Method();
            
                // prints please enter a number to the console
                Console.WriteLine("Please enter a number: ");
                // converts num1 to an int 
                int num1 = Convert.ToInt32(Console.ReadLine());
                // grabs mymethod from method.cs file and uses x - y than prints the sum onto the console
                Console.WriteLine(method.myMethod(num1));

                Console.WriteLine("Enter a second if you would like. ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(method.myMethod(num1, num2));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
