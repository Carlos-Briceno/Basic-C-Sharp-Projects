using System;
using System.Collections.Generic;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // created a list of integers 
            List<int> nums = new List<int> { 27, 44, 74, 98, 100 };

            try
            {
                // prints out pick a number from 1-10
                Console.WriteLine("Pick a number from 1-10: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();


                foreach (int i in nums)
                {
                    // divides each number in the list by the userInput 
                    int quotient = i / userInput;
                    Console.WriteLine(quotient);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a number");
            }
            catch (DivideByZeroException ex)
            {
                // prints out the message if the user trys to divide by 0 
                Console.WriteLine("Can't be divided by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The 'try and block finished' \nPlease choose a new number.");
                Console.ReadLine();
            }
        }
    }
}
