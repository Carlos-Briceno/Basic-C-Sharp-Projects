using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student" };

            // grabs employee ConsoleWriteLine and calls SayName method to print to the console 
            employee.SayName();
            Console.ReadLine();
        }
    }
}
