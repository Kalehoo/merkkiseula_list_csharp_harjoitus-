using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merkkiseula_list_csharp_harjoitus_
{
    class Program
    {
        static void Main(string[] args)
        {
            //User requests
            Console.WriteLine("Insert first word to compare:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Insert second word to compare:");
            string input2 = Console.ReadLine();

            //Forming lists
            List<(char, int)> charsummary = new List<(char, int)>(input1.Length);
            List<(char, int)> noSimilarSummary = new List<(char, int)>(input1.Length);

            //Declaring string to catch chars from words
            string test_char = "";

            for (int i = 0; i < input1.Length; i++)
            {
                // Loop searches similatrities between Word1 and Word2
                int numberOfTimesFound = 0;
                for (int j = 0; j < input2.Length; j++)
                {
                    if (input1[i] == input2[j] && test_char.Contains(input1[i]) == false)
                    {
                        numberOfTimesFound++;

                    }

                }
                // If result is more than 0, we pile it to charsummary
                if (numberOfTimesFound > 0)
                {
                    charsummary.Add((input1[i], numberOfTimesFound));
                }
                // Otherwise we send it to noSimilarSummary 
                else
                {
                    noSimilarSummary.Add((input1[i], numberOfTimesFound));
                }
                test_char += input1[i];
            }

            // Printing out results

            foreach ((char c, int i) in charsummary)
            {
                Console.WriteLine($"Character {c} found {i} times");
            }
            Console.WriteLine("Letters outcluded:");
            foreach ((char h, int l) in noSimilarSummary)
            {
                Console.WriteLine($"Character {h}");

            }

            Console.ReadKey();
        }
    }
}
