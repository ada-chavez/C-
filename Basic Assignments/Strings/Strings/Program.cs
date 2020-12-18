using System;
using System.Text;


namespace Strings
{
    class Program
    {
        static void Main()
        {
            string firstName = "Ada";
            string middleName = "Clarissa";
            string lastName = "Chavez";

            // Concatenates three strings
            string fullName = firstName + " " +  middleName + " " + lastName;
            Console.WriteLine(fullName);

            // Converts string to uppercase
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);

            // Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.

            StringBuilder sb = new StringBuilder();

            sb.Append("Paragraphs are the building blocks of papers.");
            sb.Append("Many students define paragraphs in terms of length:");
            sb.Append("a paragraph is a groupd of at least five sentences, a paragraph is alf a page long, etc.");
            sb.Append("\nIn reality, though, the unity and coherence of ideas amoung sentences is what constitutes a paragraph.");
            sb.Append("A paragraph is defined as \"a group of sentences or a single sentence that forms a unit\" (Lunsford and Connors 116).");

            Console.WriteLine(sb);

            
            Console.ReadLine();
        }
    }
}
