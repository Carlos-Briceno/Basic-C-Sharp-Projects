using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Method
    {
        public static void outPut(int x, int y)
        {
            int num1 = x / 2;
            int num2 = y;

            // prints out whats in the parenthesis plus num1 which is whatever number the user inputs divided by 2
            Console.WriteLine("First number divided by 2 = " + num1);

            // prints out second number is num2 which will be what number a user puts into the console
            Console.WriteLine("Second number is " + num2);
        }
        
        static void outPut2(int x, out int y)
        {
            y = 4;
            int results = x * y;
            y = results / 2;
        }
    }
}
