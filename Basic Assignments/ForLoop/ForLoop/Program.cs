using System;
using System.Collections.Generic;


namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)

            // UNCOMMENT EACH PART ONE AT A TIME TO RUN INDIVIDUAL PROGAM PARTS
            // MAKING SURE TO COMMENT IT OUT AGAIN BEFORE MOVING ON TO THE NEXT PART
            
        {
            /************************************************************
             PART ONE:
            1) A one-dimensional array of strings
            2) Ask the user to input some text
            3) A loop that iterates through each string in the array and adds the user's 
            text input to the end of each string.This step will not output anything to the console, 
            but will update each array element by appending the user's text
            4) Then create a loop that prints off each string in the array on a separate line
             
             ***********************************************************/

            //string[] people = { "Lilly likes to ", "Ava will reluctantly ", "Simon loves to ", "Xavier doesn't like to " };

            //Console.WriteLine("Enter a verb: ");
            //string userValue = Console.ReadLine();

            //for (int i = 0; i < people.Length; i++)
            //{
            //    people[i] = people[i] + userValue;
            //}

            //for (int j = 0; j < people.Length; j++)
            //{
            //    Console.WriteLine(people[j]);
            //}
            //Console.ReadLine();

            /************************************************************
             PART TWO:
            1) An infinite loop
            2) Save your code.
            3) Fix the infinite loop so that it will execute properly
            4) Save and execute your code
             
             ***********************************************************/

            //// Broken Loop

            //string song = "This is the song that nevers ends.";

            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine(song);
            //}
            //Console.ReadLine();

            //// Fixed Loop

            //for (int i = 0; i <= 0; i++)
            //{
            //    Console.WriteLine(song);
            //}
            //Console.ReadLine();

            /************************************************************
             PART THREE:
            1) A loop where the comparison that's used to determine whether 
            to continue iterating the loop is a "<" operator
            2) A loop where the comparison that's used to determine whether 
            to continue iterating the loops is a "<=" operator 
             ***********************************************************/

            //int[] prices = { 50, 100, 23, 250, 5 };
            //for (int j = 0; j < 5; j++)
            //{
            //    Console.WriteLine(prices[j]);
            //}


            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine(prices[i]);
            //}
            //Console.ReadLine();

            /************************************************************
             PART FOUR:
            1) A list of strings where each item in the list is unique
            2) Ask the user to input text to search for in the list
            3) A loop that iterates through the list and then displays the index
            of the list that contains matching text on the screen
            4) Add code to the loop to check if the user put in text that isn't
            on the list and, if they did, tells the user their input is not on the list.
            5) Add code to the loop that stops it from executing once a match has been found

             ***********************************************************/

            //List<string> kitchenAppliances = new List<string> { "microwave", "juicer", "blender", "instant pot" };
            //Console.WriteLine("Here is a list of kitchen appliances: ");



            //foreach (string appliance in kitchenAppliances)
            //{
            //    Console.WriteLine(appliance);

            //}

            //Console.WriteLine("\nEnter a kitchen appliance name to find out it's index number. ");
            //string userValue = Console.ReadLine();

            //bool onList = kitchenAppliances.Contains(userValue);

            //if (onList)
            //{
            //    for (int i = 0; i < kitchenAppliances.Count; i++)
            //    {
            //        if (userValue == kitchenAppliances[i])
            //        {

            //            Console.WriteLine(userValue + " is at the index of: " + kitchenAppliances.IndexOf(userValue));

            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine(userValue + " is not on the list.");
            //}

            //Console.ReadLine();

            /************************************************************
             PART FIVE:
            1) A list of strings that has at least two identical strings on the list.
            Ask the user to select text to search for in the list.
            2) Create a loop that iterates through the list and then displays the indices of
            the list that contain matching text on the screen
            3) Add code to the loop to check if the user put in text that isn't on the list and,
            if they did, tells the user their input is not on the list.

             ***********************************************************/

            List<string> animals = new List<string>() { "cat", "dog", "bird", "cow", "sheep", "cat" };

            Console.WriteLine("here is a list of animals: ");
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("\nenter an animal to find which indices they are in. ");
            string userinput = Console.ReadLine();

            bool onlist = animals.Contains(userinput);

            if (onlist)
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    if (userinput == animals[i])
                    {
                        Console.WriteLine("index: " + i);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nsorry, there is no match on the list for " + userinput);
            }
            Console.ReadLine();

            /************************************************************
             PART SIX:
            1) Create a list of strings that has at least two identical strings in the list
            2) Create a foreach loop that evaluates each item in the list, and displays
            a message showing the string whether or not it has already appeared in the list

             ***********************************************************/

            //List<string> spices = new List<string>() { "cardamom", "thyme", "saffron", "paprika", "thyme", "cumin" };

            //List<string> duplicates = new List<string>();

            //foreach (string spice in spices)
            //{
            //    if (duplicates.Contains(spice))
            //    {
            //        Console.WriteLine(spice + " has already been seen in the list.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(spice + " has not been seen in the list");
            //        duplicates.Add(spice);
            //    }

            //}
            //Console.ReadLine();
        }
    }
}
