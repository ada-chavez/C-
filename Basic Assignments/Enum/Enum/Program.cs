using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
     class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                // Prompt User
                Console.WriteLine("Enter the current day of the week.");
                string userInput = Console.ReadLine();

                // Assign User Input to enum data type DaysOfWeek
                DaysOfWeek weekday = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput);

                // Print to console
                Console.WriteLine("Have a lovely " + userInput + "!!!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }

            Console.ReadLine();
            
        }

    }

    // ENUM
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
