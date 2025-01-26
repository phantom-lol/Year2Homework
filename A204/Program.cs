using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A204
{
    internal class Program
    {
        static string VowelsToEnd(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string result = "";
            string vowelsInWord = "";
            foreach (char letter in input)
            {
                if (vowels.Contains(letter))
                {
                    vowelsInWord += letter;
                }
                else
                {
                    result += letter;
                }
            }

            return result + vowelsInWord;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string input = Console.ReadLine();
            Console.WriteLine(VowelsToEnd(input.ToLower()));
            Console.ReadKey();
        }
    }
}
