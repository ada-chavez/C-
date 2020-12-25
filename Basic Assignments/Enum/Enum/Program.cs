using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
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

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt User
                Console.WriteLine("Enter the current day of the week.");
                string userInput = ToUpper(Console.ReadLine());

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

        // Method to make first character in string Uppercase
        public static string ToUpper(string str)
        {
            // if string is nothing return nothing
            if (str == null)
            {
                return null;
            }
            else
            {
                return char.ToUpper(str[0]) + str.Substring(1);
            }


        }

    }
}
