using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The time and date right now is:");

            // DateTime to find the current date and time using 'Now'
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);

            // Prompt user for input
            Console.WriteLine("Please enter a number:\nWe will then check the time it will be 'x' number of hours from now. ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // convert userInput to timespan data type
            TimeSpan numberHours = new TimeSpan(userInput, 0, 0);

            // Add current time to numberHours
            DateTime timeInXHours = currentDateTime + numberHours;

            Console.WriteLine(timeInXHours);
            Console.ReadLine();
        }
    }
}
