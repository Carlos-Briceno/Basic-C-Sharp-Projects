using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsteuctorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var add = new Numbers();
            // prints to the console 
            Console.WriteLine($"x = {Numbers.x}, y = {Numbers.y}");
            Console.ReadLine();
        }
    }
}
