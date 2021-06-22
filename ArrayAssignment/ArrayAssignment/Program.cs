using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "this", "is", "a", "string", "array", "with", "8", "elements" };
            Console.WriteLine("Select the index of the string array between 0 and 7: ");
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            // this will make sure the user only uses numbers up to 8 
            if (stringIndex < 8 && stringIndex >= 0)
            {
                // the user used a number from 0 to 8 and this will print out 
                Console.WriteLine(stringArray[stringIndex]);
            }
            else
            {
                // the user used a different number other than 0 to 8 and this will print out 
                Console.WriteLine("the element you typed does not exist.");
            }


            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Select the index of the int array between 0 and 9: ");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            if (intIndex < 9 && intIndex >= 0)
            {
                Console.WriteLine(intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("the element you typed does not exist");
            }


            // this creates a string of lists that will be used to print out 
            List<string> stringList = new List<string>() { "this", "is", "a", "list", "of", "strings"};
            Console.WriteLine("Select the index of the string from 0 to 5: ");
            // this converts the strings into a int so when the user goes to type an answer they will use numbers instead 
            int listIndex = Convert.ToInt32(Console.ReadLine());
            if (listIndex < 8 && listIndex >= 0)
            {
                Console.WriteLine(stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("the element you typed does not exsit");
            }

            Console.ReadLine();
        }
    }
}
