using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate Product class
            Product product = new Product();

            // Call the  Multiply Method passing parameters by name
            product.Multiply(num1: 10, num2: out int num2);

            Console.ReadLine();
        }
    }
}
