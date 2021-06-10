using System;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            // this will print out Anonymous Income Comparison to the console and also Person 1 under that and also under person 1 Hourly rate will print out too 
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly rate:");
            string p1HrRate = Console.ReadLine();
            decimal p1_HrRate = Convert.ToDecimal(p1HrRate);
            Console.WriteLine("Hours worked Per Week:");
            string p1HrsWorked = Console.ReadLine();
            int p1_HrsWorked = Convert.ToInt32(p1HrsWorked);
            // this will multipy the p1_HrRate by p1_HrsWorked to get the total of person 1's annual salary 
            decimal p1_annualSalary = p1_HrRate * p1_HrsWorked * 52;

            Console.WriteLine("Person 2\nHourly rate:");
            string p2HrRate = Console.ReadLine();
            decimal p2_HrRate = Convert.ToDecimal(p2HrRate);
            Console.WriteLine("Hours worked Per Week:");
            string p2HrsWorked = Console.ReadLine();
            int p2_HrsWorked = Convert.ToInt32(p2HrsWorked);
            decimal p2_annualSalary = p2_HrRate * p2_HrsWorked * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(p1_annualSalary);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(p2_annualSalary);
            Console.WriteLine("Does Person 1 make more money that Person 2?");
            // bool salCompare will print out false if p1_annualSalary is greater then p2_annualSalary or print out true if p1 is equal to p2 
            bool salCompare = p1_annualSalary >= p2_annualSalary;
            Console.WriteLine(salCompare);
            Console.ReadLine();
        }
    }
}
