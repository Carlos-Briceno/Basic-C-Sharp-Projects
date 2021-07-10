using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Method
    {
        public void myMethod (int x, int y)
        {
            int operation = x + 12;
            Console.WriteLine(operation);

            Console.WriteLine(y);

            // grabs operation and displays the sum
            Console.WriteLine("The sum of x and 12 is " + operation);
            // grabs y and displays the value of y
            Console.WriteLine("The value of y is " + y);
        }
    }
}
