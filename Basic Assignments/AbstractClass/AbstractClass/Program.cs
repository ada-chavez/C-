using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate & Initialize Two Employee Class Objects
            Employee employeeOne = new Employee() { Id = 301 };
            Employee employeeTwo = new Employee() { Id = 303 };

            // Call Overload Operator Methods
            bool areEqual = employeeOne.Id == employeeTwo.Id;
            bool notEqual = employeeOne.Id != employeeTwo.Id;

            // Print to Console
            Console.WriteLine("Overload Operator '=='\nDoes employee one have the same Id as employee two?\n" + areEqual);
            Console.WriteLine("\nOverload Operator '!='\nDoes employee one NOT have the same Id as employee two Id?\n" + notEqual);

            // Instantiate Employee Class
            Employee employee = new Employee();

            // Initialize Employee Object
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call method SayName()
            employee.SayName();

            // Polymorphism to create object type IQuittable
            IQuittable quittable = new Employee();

            // Call method Quit()
            quittable.Quit();

            Console.ReadLine();

        }
    }
}
