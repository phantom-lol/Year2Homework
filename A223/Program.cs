using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace A223
{
    class Program
    {
        static string GetMiddle(string word)
        {
            if (word.Length % 2 != 0)
            {
                return word[word.Length / 2].ToString();
            }
            else
            {
                return word.Substring((word.Length / 2) - 1, 2);
            }
        }

        static int highestValueConsonantSubstring(string input)
        {
            List<string> consonants = listOfConsonantSubstring(input);
            List<int> results = new List<int>();
            for (int i = 0; i < consonants.Count; i++)
            {
                int result = 0;
                for (int j = 0; j < consonants[i].Length; j++)
                {
                    result += (int)consonants[i][j] - 96;
                }
                results.Add(result);
            }
            return results.Max();
        }

        static List<string> listOfConsonantSubstring(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            List<string> consonants = new List<string>();
            string temp = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (!vowels.Contains(input[i]))
                {
                    temp += input[i];
                }
                else
                {
                    consonants.Add(temp);
                    temp = "";
                }
            }

            if (temp.Length > 0)
            {
                consonants.Add(temp);
            }

            return consonants;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter input: ");
            string input = Console.ReadLine();
            Console.WriteLine(highestValueConsonantSubstring(input));
            Console.ReadKey();
        }
    }
}
