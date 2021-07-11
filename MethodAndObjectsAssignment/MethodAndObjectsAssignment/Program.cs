using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            // grabs FirstName from Person file and than prints out Sample to console 
            employee.FirstName = "Sample";
            // grabs LastName from Person file than prints out student to console 
            employee.LastName = "Student";
            employee.PersonName();
        }
    }
}
