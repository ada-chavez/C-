using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare num1 of type Number
            Number num1;

            // Asign a number to Amount
            num1.Amount = 268m;

            // Print Amount to console
            Console.WriteLine("Amount: " + num1.Amount);
            Console.ReadLine();

        }
    }
}
