using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A219
{
    internal class Program
    {
        static string mirror(string ciphertext, string alphabet)
        {
            char[] alphabetChars = alphabet.ToCharArray();
            string result = "";
            foreach (char c in ciphertext)
            {
                int charNum = (int)c - 96;
                if (charNum <= alphabetChars.Length && c != ' ')
                {
                    result += alphabetChars[alphabetChars.Length - charNum];
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine($"Test 1: {mirror("jehjb teh tedri gaoor jorrdior", "abcdefghijkl")}");
            Console.WriteLine($"Test 2: {mirror("rtarm efaapc", "abcdefghijklmnopqrst")}");
            Console.ReadKey();
        }
    }
}
