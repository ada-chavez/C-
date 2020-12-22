using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating Mth Class
            Mth math = new Mth();

            // Propmt User for input
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling first add method
            Console.WriteLine(math.add(num));

            // Propmt User for input
            Console.WriteLine("\nEnter a second number");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            // Calling second add method
            Console.WriteLine(math.add(num2));

            // Propmt User for input
            Console.WriteLine("\nEnter a third number");
            string num3 = Console.ReadLine();
            // Calling third add method
            Console.WriteLine(math.add(num3));

            Console.ReadLine();

        }
    }
}
