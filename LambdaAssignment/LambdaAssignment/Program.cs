using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main()
        {
            // creates a new list of employees with an id 
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { FirstName = "Joe", LastName = "Green", Id = 1 });
            employees.Add(new Employee { FirstName = "Ryan", LastName = "Reynolds", Id = 2 });
            employees.Add(new Employee { FirstName = "Lisa", LastName = "Smith", Id = 3 });
            employees.Add(new Employee { FirstName = "John", LastName = "Doe", Id = 4 });
            employees.Add(new Employee { FirstName = "James", LastName = "Charles", Id = 5 });
            employees.Add(new Employee { FirstName = "Joe", LastName = "Johnson", Id = 6 });
            employees.Add(new Employee { FirstName = "Jonny", LastName = "Pesto", Id = 7 });
            employees.Add(new Employee { FirstName = "Jason", LastName = "Wayne", Id = 8 });
            employees.Add(new Employee { FirstName = "Madi", LastName = "May", Id = 9 });
            employees.Add(new Employee { FirstName = "Jane", LastName = "Doe", Id = 10 });

            List<Employee> Templist = new List<Employee>();
            foreach (var employee in employees)
            {
                // grabs every first name that is joe
                if (employee.FirstName == "Joe")
                {
                    Templist.Add(employee);
                }
            }
            // gets everyone employee in Templist
            foreach (Employee employee in Templist)
            {
                Console.WriteLine(employee.FirstName);
            }
            List<Employee> joe = employees.Where(x => x.FirstName == "Joe").ToList();
               
            // grabs every employee in the list with the name joe in it 
            foreach (Employee employee in joe)
            {
                Console.WriteLine(employee.FirstName);
            }

            List<Employee> GreatThanFive = employees.Where(x => x.Id > 5).ToList();
            // prints every employee that as an id greater than 5
            Console.WriteLine("list of all employees with an Id number greater than 5");


            foreach (Employee employee in GreatThanFive)
            {
                // after grabing every employee greater than 5 it than prints the employees first name, last name, and id number
                Console.WriteLine("First Name: " + employee.FirstName + " Last Name: " + employee.LastName + " ID: " + employee.Id);
            }
            Console.ReadLine();
        }
    }
}
