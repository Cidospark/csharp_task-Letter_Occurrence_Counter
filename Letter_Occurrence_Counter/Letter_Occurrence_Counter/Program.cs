using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Occurrence_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt and accept string from user
            Console.WriteLine("Task 1");
            Console.Write("Enter a string:\t");
            var str = String.Empty;
            str = Console.ReadLine();

            // check for valid English letters if entered string is not empty
            if (!(str.Trim().Equals(String.Empty)) || str != null)
            {
            }
            else
            {
                Console.WriteLine("You need to enter at least a character");

            }
        }
    }


    class Printer
    {
        public void PrintIt(Dictionary<char, int> listOfStrings)
        {
            foreach (KeyValuePair<char, int> c in listOfStrings)
            {
                Console.Write($"\t{c.Key}");
            }
            Console.WriteLine();
            foreach (KeyValuePair<char, int> c in listOfStrings)
            {
                Console.Write($"\t{c.Value}");
            }

            Console.WriteLine($"\n\nTotal letters counted: {Helper.validLettersCounts} out of {str.Length} characters entered");
            Console.ReadLine();
        }
    }
}
