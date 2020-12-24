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
        // Methods
        // Implement abstract SayName() method
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Implement Quit() method
        public void Quit()
        {
            Console.WriteLine("\nQuit method called");
        }
    }
}
