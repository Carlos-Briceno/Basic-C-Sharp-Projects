using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsteuctorAssignment
{
    class Program
    {
        static void Main()
        {
            const string Name = "Carlos Briceno";
            var School = "The Tech Academy";

            Console.WriteLine("{0} is attending {1}.", Name, School);
            // creates a newPerson which will be used in the next line of code 
            var newPerson = new Const("Mike Scott","The Tech Academy");
            // chains two constructors togther which are Name and School and also prints to the console
            Console.WriteLine($"{newPerson.Name} is attending {newPerson.School}");
            Console.ReadLine();
        }
    }
}
