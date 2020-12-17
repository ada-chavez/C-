using System;


namespace InsuranceEligibility
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insurance Eligibility Program\n");

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\" ");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());

            // Checks input to see if user is qualified for insurance
            // If age is over 15 AND dui is false AND speeding tickets is less than 3
            bool isQualified = age > 15 && dui == false && ticket < 3;
            Console.WriteLine("Qualified?\n" + isQualified );

            Console.ReadLine();

        }
    }
}
