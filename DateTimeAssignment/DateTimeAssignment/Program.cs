using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is grabbing the current time from today 
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Please enter a number: ");
            try
            {
                // converts num1 to an int
                int num1 = Convert.ToInt32(Console.ReadLine());
                TimeSpan futureTime = new TimeSpan(num1, 0, 0);
                DateTime addedTime = currentTime.Add(futureTime);
                if (num1 <= 1)
                {
                    // grabs user input and than adds it to the current time 
                    Console.WriteLine("in " + num1 + " hour, the time will be " + addedTime);
                }
                else
                {
                    Console.WriteLine("in " + num1 + " hours, the time will be " + addedTime);
                }
            }
            catch (FormatException)
            {
                // if the number is not entered than this error message will print to the console
                Console.WriteLine("Please type a number");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
