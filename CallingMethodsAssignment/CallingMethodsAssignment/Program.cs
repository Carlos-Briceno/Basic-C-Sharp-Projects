using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a nunber: ");
            int randomNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number: ");
            string randomStr = Console.ReadLine();

            Param param = new Param();

            if (randomStr == "")
            {
                Console.WriteLine(param.Method1(randomNum));
            }

            else
            {
                int number = Convert.ToInt32(randomStr);
                // prints off Method1 which is x + y after the user picks two numbers which will come from randomNum and number 
                Console.WriteLine(param.Method1(randomNum, number));
                
                Console.WriteLine(param.Method2(randomNum, number));
                
                Console.WriteLine(param.Method3(randomNum, number));
            }
            Console.ReadLine();
        }
    }
}
