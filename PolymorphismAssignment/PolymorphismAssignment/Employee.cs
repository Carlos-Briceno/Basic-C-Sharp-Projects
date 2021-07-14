using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            // prints off to the console 
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.Write("Has quit");
        }
    }
}
