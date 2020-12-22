using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating Add Class
            Add add = new Add();

            int result;

            // Prompt User for first input
            Console.WriteLine("Enter a number");
            int valueOne = Convert.ToInt32(Console.ReadLine());

            // Prompt User for the second input
            Console.WriteLine("\nEnter another number, but you do not have to.");
            string valueTwo = Console.ReadLine();

            // Check to see if user input an empty value
            if (string.IsNullOrEmpty(valueTwo))
            {
                result = add.Sum(valueOne);
            }
            else
            {
                result = add.Sum(valueOne, Convert.ToInt32(valueTwo));
            }

            // Display results
            Console.WriteLine("\n" + result);

            Console.ReadLine();

        }
    }
}
