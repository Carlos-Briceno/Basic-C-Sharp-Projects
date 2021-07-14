using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { FirstName = "Sample", LastName = "Student" };

            IQuittable quittable = new Employee();

            // prints Name: sample student
            employee.SayName();
            // prints out has quit into the console 
            quittable.Quit();
            Console.ReadLine();
        }
    }
}
