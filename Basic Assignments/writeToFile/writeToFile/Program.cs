using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace writeToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a number:");
            string userInput = Console.ReadLine();

            // Log userInput number to text file
            File.WriteAllText(@"C:\Users\Victoria\Logs\log.txt", userInput);

            // Store text file into a string
            string userNumber = File.ReadAllText(@"C:\Users\Victoria\Logs\log.txt");

            // Print text file back to user
            Console.WriteLine("\nHere is whats in the text file: " + userNumber );
            
            Console.ReadLine();


        }
    }
}
