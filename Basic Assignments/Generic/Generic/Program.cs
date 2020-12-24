using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Employee object w/ type string
            Employee<string> Ada = new Employee<string>();

            // Instantiate Employee object w/ type int
            Employee<int> Scott = new Employee<int>();

            // String list
            List<string> officeSupplies = new List<string>()
            {
                "desk",
                "chair",
                "printer"
            };

            // Int list
            List<int> Id = new List<int>()
            {
                301,
                302,
                303
            };

            // Assign string list to Employee class property Things
            Ada.Things = officeSupplies;

            // Assign int list to Empployee class property Things
            Scott.Things = Id;


            // Print to console
            Console.WriteLine("Office Supples:");
            foreach (string thing in Ada.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nId numbers:");
            foreach (int thing in Scott.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();

        }
    }
}
