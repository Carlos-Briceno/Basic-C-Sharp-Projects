using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
   public class Employee : Person
    {
        public override void SayName()
        {
            // prints off to the console 
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
