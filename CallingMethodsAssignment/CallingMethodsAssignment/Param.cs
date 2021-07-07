using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
   public class Param
    {
        public int Method1 (int x, int y = 0)
        {
            int result = x + y;
            // returns the result which is x + y
            return result;
        }
    }
}
