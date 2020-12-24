using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Inherit from Person Class and Quittable Interface
   public class Employee : Person, IQuittable
    {
        // Properties
        public int Id { get; set; }

        // Methods
        // Implement abstract SayName() method
        public override void SayName()
        {
            Console.WriteLine("\nName: " + FirstName + " " + LastName);
        }

        // Implement Quit() method
        public void Quit()
        {
            Console.WriteLine("\nQuit method called");
        }

        // Overload Operators
        // Checks two Employee objects are equal by their Id property
        public static Employee operator== (Employee employee, Employee Id)
        {
            employee.Equals(Id);
            return employee;
        }

        // NOTE: operator== requires an 'operator!=' to be defined
        public static Employee operator!= (Employee employee, Employee Id)
        {
            employee.Equals(Id);
            return employee;
        }
           


    }
}
