using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    public class Product
    {
        // void specifies that this method doesn't return a value
        public void Multiply (int num1, out int num2)
        {
            // Math operation on first parameter behind the scenes
            int result = num1 * 2;

            // Display second parameter to screen
            num2 = 33;
            Console.WriteLine("The second parameter value is: {0} ", num2);
        }
    }
}
