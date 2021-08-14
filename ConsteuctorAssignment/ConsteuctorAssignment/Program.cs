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
            // const string name is Carlos Briceno 
            const string Name = "Carlos Briceno";
            // the var school is The Tech Academy 
            var school = "The Tech Academy";
            
            var Const = new Const(Name);
            // prints {name} is attending {school}.
            Console.WriteLine("{0} is attending {1}.", Name, school);
            Console.ReadLine();
        }
    }
}
