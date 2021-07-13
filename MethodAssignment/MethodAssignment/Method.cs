using System;
using System.Collections.Generic;

namespace MethodAssignment
{
   public class Method
    {
         public int myMethod(int x, int y = 4)
        {
            int result = x - y;
            return result;
        }
    }
}
