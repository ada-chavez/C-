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
            // Instantiate Employee class
            Employee employee = new Employee();

            // Initialize Employee Object
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call method SayName()
            employee.SayName();

            Console.ReadLine();

        }
    }
}
