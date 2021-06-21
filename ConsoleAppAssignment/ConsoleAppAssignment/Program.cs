using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            // this is a while loop
            while (i < 10)
            {
                // this will print out i = 0 to 1 = 9
                Console.WriteLine("i = {0}", i);
                i++;
            }


            int j = 0;
            // this is a do while loop 
            do
            {
                Console.WriteLine("j = {0}", j);
                j++;
                
                if (j > 5)
                    // this will print out j = 0 to j = 5 because the break will make it stop at 5 
                    break;

            } while (j < 10);

            Console.ReadLine();
        }
    }
}
