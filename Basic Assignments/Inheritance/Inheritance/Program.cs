using System;

namespace Inheritance
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

            // Call superclass method SayName()
            employee.SayName();

            Console.ReadLine();
        }
    }
}
