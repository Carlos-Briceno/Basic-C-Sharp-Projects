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
            const string newName = "My name is ";
            const string Age = "My age is ";
            // asks user to enter their age or name 
            Console.WriteLine("Enter your age or name: ");
            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x))
            {
                // prints "My age is " to the console 
                Console.WriteLine(Age);
                Const newChain = new Const(x);
            }
            else
            {
                // priints "My name is " to the console 
                Console.WriteLine(newName);
                Const newChain = new Const(answer);
            }
            Console.ReadLine();
        }
    }
}
