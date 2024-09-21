using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A200
{
    internal class Program
    {
        static List<int> alphabetPositions(List<string> strings)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            List<int> numbers = new List<int>();
            foreach (string s in strings)
            {
                int amount = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i].ToString().ToLower() == alphabet[i].ToString())
                    {
                        amount++;
                    }
                }
                numbers.Add(amount);
            }
            return numbers;
        }
        
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            strings.Add("ABodE");
            strings.Add("xBkd");
            Console.WriteLine("Using words:");
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            List<int> numbers = alphabetPositions(strings);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
