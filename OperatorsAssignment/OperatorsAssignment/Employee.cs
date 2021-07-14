using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee : Person
    {
        public int Id = 0;

        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }

        public static bool operator ==(Employee a, Employee b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return a.Id != b.Id;
        }
    }
}
