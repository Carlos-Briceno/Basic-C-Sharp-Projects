using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you qualify for car insurance?\nWhat is your age?");
            // When you reply to what is ya age you can answer any number up to 32,767 since it is Int16.
            short age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? if yes say 'true' or if no say 'false'.");
            // When you answer have you ever had a DUI answer true or false since it is converted to a boolean
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            short tickets = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qualification status: ");
            // age greater than 16 and dui equals false and less than or equal to 4 tickets. 
            bool qualify = age > 16 && dui == false && tickets <= 4;
            Console.WriteLine(qualify);
            Console.ReadLine();
        }
    }
}
