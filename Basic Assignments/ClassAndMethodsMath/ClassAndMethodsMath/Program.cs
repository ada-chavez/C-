using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsMath
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt user for input
                Console.WriteLine("Enter a number to perform basic math on... ");
                int num = Convert.ToInt32(Console.ReadLine());


                // Creating an object from the Class called MathClass
                MathClass math = new MathClass();

                // Calling the 3 math methods within the Class MathClass
                // using the object math that was created prior
                int sumResult = math.sum(num);
                int quotientResult = math.quotient(num);
                int productResult = math.product(num);


                // Display results to User
                Console.WriteLine("\n" + num + " + 33 = " + sumResult);
                Console.WriteLine(num + " / 2 = " + quotientResult);
                Console.WriteLine(num + " x 3 = " + productResult);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
