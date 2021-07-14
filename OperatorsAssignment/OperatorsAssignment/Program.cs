using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a new employee with a name 
            Employee worker1 = new Employee("Harry", "Potter");
            Employee worker2 = new Employee("Bob", "Ross");

            // prints this to the console
            Console.WriteLine("Are the employees the same?");
            // prints result to the console either true or false
            Console.WriteLine("Result: " + Convert.ToString(worker1 == worker2));
            Console.ReadLine();
        }
    }
}
