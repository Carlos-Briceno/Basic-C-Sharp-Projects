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
          //  const string Name = "Carlos Briceno";
          //  var School = "The Tech Academy";

            // Console.WriteLine("{0} is attending {1}.", Name, School);
            // creates a newPerson which will be used in the next line of code 
            //   var newPerson = new Const("Mike Scott","The Tech Academy");
            //   Console.WriteLine($"{newPerson.Name} is attending {newPerson.School}");
            //  Console.ReadLine();


            const string newName = "This string is a const variable!";
            var anotherName = "This is a string variable using var";

            Console.WriteLine(newName);
            Console.WriteLine(anotherName);
            Console.ReadLine();
        }

        public class sampleChain
        {
            public sampleChain()
            {

            }
            public sampleChain(int age) : this()
            {
                this.Age = age;
            }
            public sampleChain(int age, string name) : this(age)
            {
                this.Name = name;
            }
            public int Age { get; set; }
            public string Name { get; set; }


        }
    }
}
