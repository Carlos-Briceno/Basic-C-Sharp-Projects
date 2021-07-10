using System;
using System.Collections.Generic;

namespace MethodAssignment
{
   public class Method
    {
        static public void myMethod(int x, int y = 4)
        {
            Console.WriteLine(x - y);
        }
    }
}
