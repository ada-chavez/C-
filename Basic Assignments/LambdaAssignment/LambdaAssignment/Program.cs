using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee class
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "Ada", LastName = "Chavez", Id = 1 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Dukes", Id = 2 });
            employees.Add(new Employee() { FirstName = "Scott", LastName = "King", Id = 3 });
            employees.Add(new Employee() { FirstName = "Megan", LastName = "LaPlante", Id = 4 });
            employees.Add(new Employee() { FirstName = "Christine", LastName = "Ngyuen", Id = 5 });
            employees.Add(new Employee() { FirstName = "Chang", LastName = "Kim", Id = 6 });
            employees.Add(new Employee() { FirstName = "Jason", LastName = "Lee", Id = 7 });
            employees.Add(new Employee() { FirstName = "Veronica", LastName = "Smith", Id = 8 });
            employees.Add(new Employee() { FirstName = "Ren", LastName = "Hom", Id = 9 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Deguzman", Id = 10 });



            // Foreach loop to create new list of employees with first name 'Joe'
            List<Employee> forEachList = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    forEachList.Add(employee);
                }
            }

            // Print to console forEachList
            Console.WriteLine("Foreach Loop Method:");
            foreach (Employee employee1 in forEachList)
            {
                Console.WriteLine(employee1.FirstName + " " + employee1.LastName + " " + employee1.Id);
            }


            // Lambda Expression to create new list of employees with first name 'Joe'
            List<Employee> joeList = employees.Where(x => x.FirstName == "Joe").ToList();

            // Print to console lambda method
            Console.WriteLine("\nLambda Expression Method:");
            foreach (Employee joe in joeList)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName + " " + joe.Id);
            }


            // Lambda expression to create a new list of employees with Id greater than 5
            List<Employee> idList = employees.Where(x => x.Id > 5).ToList();

            // Print to console
            Console.WriteLine("\nEmployees with an Id greater than 5:");
            foreach (Employee id in idList)
            {
                Console.WriteLine( id.FirstName + " " + id.LastName );
            }
            Console.ReadLine();
        }
    }
}
