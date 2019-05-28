using System;
using System.Collections.Generic;

namespace word_list_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DICTIONARY TIME, BUDDY!");

            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Clam", "a delightful and sometimes misunderstood shellfish");
            wordsAndDefinitions.Add("Squidding", "the act of catching squid, oftentimes occurring in the dead of night");
            wordsAndDefinitions.Add("Nightcrawler", "big ol' nocturnal worm used for bait");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Clam"]);
            Console.WriteLine(wordsAndDefinitions["Squidding"]);
            Console.WriteLine("-----------------------");
            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value} ");
                Console.WriteLine("-----------------------");
            };


        }
    }
}
