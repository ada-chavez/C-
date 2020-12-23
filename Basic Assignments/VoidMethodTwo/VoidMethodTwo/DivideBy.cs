using System;


namespace VoidMethodTwo
{
    public class DivideBy
    {
        // Void method that outputs an integer
        public void ByTwo (int numOne)
        {
            Console.WriteLine("\n" + numOne + " / 2 = " + numOne / 2);
        }

        // Overload ByTwo method
        public void ByTwo (int numOne, out int numTwo)
        {
            numTwo = numOne / 2;
            Console.WriteLine("\nOverload Method: " + numOne + " / 2 = " + numOne / 2);
        }
    }
}
