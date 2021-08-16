using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsteuctorAssignment
{
   public class Const
    {
            public Const(float age1) : this(age1, "Carlos")
            {
                Console.WriteLine(age1 + " and your name is " + Name);
            }
            public Const(string name1) : this(23, name1)
            {
                Console.WriteLine(name1 + " and your age is " + Age);
            }
            public Const(float age, string name)
            {
                Age = age;
                Name = name;
            }
            float Age { get; set; }
            string Name { get; set; }
        }
    }
