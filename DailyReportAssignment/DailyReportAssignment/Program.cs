using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // this prints out in the start of the program 
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();


            // when you type in ya name it will print out welcome and than your name
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            Console.WriteLine("Welcome, " + myName);
            Console.ReadLine();


            // When you type in the course you are on it will print out again 
            Console.WriteLine("What course are you on?");
            string myCourse = Console.ReadLine();
            Console.WriteLine(myCourse);
            Console.ReadLine();


            // the user will plug in a number and than the console will print out Your page number is, and what ever the number they type in. 
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            int num = pageNum;
            Console.WriteLine("Your page number is, " + pageNum);
            Console.ReadLine();


            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            bool isTrue = true;
            bool isFalse = false;
            Console.WriteLine(isTrue);
            Console.WriteLine(isFalse);
            Console.ReadLine();


            // When you answer the question thank you for your answer will print out after 
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string explain = Console.ReadLine();
            Console.WriteLine("Thank you for your answer!");
            Console.ReadLine();


            // when you answer the question thank you for giving us feedback will print out 
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string textExplain = Console.ReadLine();
            Console.WriteLine("Thank you for giving us feedback!");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            string hoursStudied = Console.ReadLine();
            int hoursStu = Convert.ToInt32(hoursStudied);
            int hoursStudy = hoursStu;
            Console.WriteLine("Total hours studied: " + hoursStu);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
