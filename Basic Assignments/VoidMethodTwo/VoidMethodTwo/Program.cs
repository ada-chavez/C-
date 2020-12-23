using System;


namespace VoidMethodTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Instantiate DivideBy class
                DivideBy mth = new DivideBy();

                // Prompt user for input
                Console.WriteLine("Enter a number");
                int userInput = Convert.ToInt32(Console.ReadLine());

                // Call method from DivideBy class
                mth.ByTwo(userInput);

                // Call overload method from DivideBy class
                mth.ByTwo(userInput, out int numTwo);

                // Call method from static class
                // Note: static class cannot be instantiated
                StaticClass.Details();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Error: Not a whole number!\nGoodbye!");
            }
            catch(Exception ex)
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
