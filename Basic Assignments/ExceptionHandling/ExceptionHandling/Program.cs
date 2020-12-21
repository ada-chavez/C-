using System;
using System.Collections.Generic;


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 55, 464, 1258, 123, 8974, 59, 100 };

            try
            {
                Console.WriteLine("Enter a number to divide a list of integers by: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    Console.WriteLine(number + " divided by " + userInput + " equals: " + number / userInput);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
            
        }
    }
}
