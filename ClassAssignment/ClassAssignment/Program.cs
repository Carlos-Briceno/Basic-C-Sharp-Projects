using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose another number: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            // grabs ouPut method and displays userInput and user Input2
            Method.outPut(userInput, userInput2);
            Console.ReadLine();

        }
    }
}
