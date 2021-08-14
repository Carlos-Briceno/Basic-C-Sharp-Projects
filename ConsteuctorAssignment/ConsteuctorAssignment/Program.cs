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
            const string Name = "Carlos Briceno";
            var school = "The Tech Academy";

            var Const = new Const(Name);
            Console.WriteLine("{0} is attending {1}.", Name, school);
            Console.ReadLine();
        }
    }
}
