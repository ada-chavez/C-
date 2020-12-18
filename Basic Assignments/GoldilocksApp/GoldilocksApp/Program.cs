using System;


namespace GoldilocksApp
{
    class Program
    {
        static void Main()
        {
            // initializes program game to start
            bool game = true;

            do
            {
                Console.WriteLine("Would you like to play? Enter yes or no");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                        Console.WriteLine("\nHow does Goldilocks like her porridge: cold, hot, or warm?");
                        string porridgetemp = Console.ReadLine();

                        bool guess = porridgetemp == "warm";

                        while (!guess)
                        {
                            switch (porridgetemp)
                            {
                                case "cold":
                                    Console.WriteLine("\nEw she doesn't want cold gummy porridge.\nTry again!");
                                    porridgetemp = Console.ReadLine();
                                    break;

                                case "hot":
                                    Console.WriteLine("\nThis porridge is much too hot! she may burn her tongue.\nTry again!");
                                    porridgetemp = Console.ReadLine();
                                    break;

                                case "warm":
                                    Console.WriteLine("\nOh, warm porridge is just right! Now maybe there's a bed she can find to nap in.");
                                    Console.ReadLine();
                                    // when guess is true it gets out of the while loop.
                                    guess = true;
                                    break;

                                default:
                                    Console.WriteLine("\nOops! Please enter one of the porridge choices: \n\"cold\" \"hot\" or \"warm\"");
                                    porridgetemp = Console.ReadLine();
                                    break;


                            }

                        }                  
                }
                else if (answer == "no")
                {
                    Console.WriteLine("\nThank you! Goodbye!");
                    // when game is false it gets out of the do while loop
                    game = false;
                }
                else
                {
                    Console.WriteLine("Oops! That is not a valid answer. \nExiting program. Goodbye!");
                    game = false;
                }

            } while (game);
     
            Console.Read();
        }
    }
}
