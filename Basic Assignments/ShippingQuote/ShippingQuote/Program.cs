using System;


namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            
            // Get package weight from user input
            Console.WriteLine("Please enter the package weight in pounds:");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            // If package weighs more than 50 it's too heavy else continue with the user input of package dimensions
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width in inches:");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height in inches:");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length in inches:");
                double length = Convert.ToDouble(Console.ReadLine());


                // Calculate dimension and store in variable called dimension
                double dimension = width + height + length;

                // Convert to decimal when dealing with money quotes
                decimal quote = Convert.ToDecimal(((width * height * length) * weight) / 100);

                // Ternary Operator: If package dimension is over 50 it's too big else provide quote
                string result = dimension > 50 ? "\nPackage too big to be shipped via Package Express." : "\nYour estimated total for shipping this package is: $" + quote + "\nThank you!";
                Console.WriteLine(result);

                Console.ReadLine();
            }
        }
    }
}
