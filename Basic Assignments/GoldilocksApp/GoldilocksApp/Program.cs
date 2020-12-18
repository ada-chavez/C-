using System;


namespace GoldilocksApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How does Goldilocks like her porridge: cold, hot, or warm?");
            string porridgeTemp = Console.ReadLine();
            
            // Set guess to True when porridgeTemp is "warm"
            bool guess = porridgeTemp == "warm";

            // Do while statment. Do this while porridgeTemp is not "warm"
            do
            {
                switch (porridgeTemp)
                {
                    case "cold":
                        Console.WriteLine("Ew she doesn't want cold gummy porridge.\nTry again!");
                        porridgeTemp = Console.ReadLine();
                        break;

                    case "hot":
                        Console.WriteLine("Oh this porridge is much too hot! She may burn her tongue.\nTry again!");
                        porridgeTemp = Console.ReadLine();
                        break;

                    case "warm":
                        Console.WriteLine("Oh warm porridge is just right! Now maybe there's a bed she can find to nap in...");                                           
                        break;

                    default:
                        Console.WriteLine("Oops! Please enter one of the porridge choices: \n\"cold\" \"hot\" or \"warm\"");
                        porridgeTemp = Console.ReadLine();
                        break;


                }
            }
            while (!guess);
            Console.Read();
        }
    }
}
