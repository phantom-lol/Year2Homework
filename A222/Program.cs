using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A222
{
    internal class Program
    {
        static Dictionary<char, int> CalculateErrors(string input)
        {
            Dictionary<char, int> errors = new Dictionary<char, int>();
            int uTotal = 0, wTotal = 0, xTotal = 0, zTotal = 0;
            foreach (char letter in input)
            {
                switch (letter)
                {
                    case 'u':
                        uTotal++; break;
                    case 'w':
                        wTotal++; break;
                    case 'x':
                        xTotal++; break;
                    case 'z':
                        zTotal++; break;
                }
            }
            errors.Add('u', uTotal); errors.Add('w', wTotal); errors.Add('x', xTotal); errors.Add('z', zTotal);
            return errors;
        }

        static void DisplayHistogram(Dictionary<char, int> errors)
        {
            int top = 2;
            foreach (KeyValuePair<char, int> error in errors)
            {
                Console.Write($"{error.Key}  {error.Value}");
                Console.SetCursorPosition(9, top);
                for (int i = 0; i < error.Value - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
                top++;
            }
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            string input = "wpetrificusutotalusuwuexpectoupatronumuwuwingardiumuleviosauwu";
            Console.WriteLine($"Input: {input}");
            Console.WriteLine();
            DisplayHistogram(CalculateErrors(input));
        }
    }
}
