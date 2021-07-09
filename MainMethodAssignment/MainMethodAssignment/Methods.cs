using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Methods
    {
        public int myMethod1(int num)
        {
            // prints out the sum on the console
            return num / 4;
        }


        public int myMethod2(decimal d)
        {
            return Convert.ToInt32(d % 10);
        }

        public int myMethod3(string s)
        {
            // converts string into int 
            int result = Convert.ToInt32(s) + 1000;
            // returns int result 
            return result;
        }
    }
}
