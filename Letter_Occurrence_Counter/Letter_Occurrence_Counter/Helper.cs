using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Occurrence_Counter
{
    class Helper
    {
        public static int validLettersCounts = 0;
        public static Dictionary<char, int> util(string str)
        {

            var listOfStrings = new Dictionary<char, int>();
            var countUniques = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                {
                    int incr = 0;

                    char charLower = char.ToLower(c);
                    if (listOfStrings.TryGetValue(charLower, out incr))
                    {
                        incr = listOfStrings[charLower];
                        incr++;
                        listOfStrings[charLower] = incr;
                    }
                    else
                    {
                        listOfStrings.Add(charLower, 1);
                    }
                }
                validLettersCounts = listOfStrings.Count();

            }

            return listOfStrings;
        }
    }
}
