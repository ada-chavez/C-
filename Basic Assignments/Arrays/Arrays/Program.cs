using System;
using System.Collections.Generic;


namespace Arrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Learn more about a country!");

            // Array of strings
            string[] language = {"Tagalog", "Arabic", "Setswana", "Hindi"};

            // Array of integers
            int[] population = { 106, 36, 2, 1000 };

            // List of strings
            List<string> country = new List<string>();
            country.Add("Philippines");
            country.Add("Morocco");
            country.Add("Botswana");
            country.Add("India");

            bool again = true;

            do
            {
                Console.WriteLine("\nEnter an index number..");
                int num = Convert.ToInt32(Console.ReadLine());
                bool index = num >= 0 && num <= 3;

                if (index)
                {

                    Console.WriteLine("Country: " + country[num]);
                    Console.WriteLine("Language: " + language[num]);
                    Console.WriteLine("Population: " + population[num] + " million");
                    Console.WriteLine("Thank you for learning more about " + country[num] +"!");
                    again = false;

                }
                else
                {
                    Console.WriteLine("This index does not exist.\nTry a number between 0-3.");


                }


            } while (again);

            Console.ReadLine();
        }
    }
}
