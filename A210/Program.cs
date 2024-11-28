using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A210
{
    internal class Program
    {
        static int GrawpOs(string text)
        {
            char[] oneO = { 'a', 'b', 'd', 'e', 'g', 'o', 'p', 'q', '0', '6', '9', 'D', 'O', 'P', 'Q', 'R', '@', '(', ')'};
            char[] twoO = { '%', '&', 'B', '8' };
            int numOfOs = 0;
            foreach (char letter in text)
            {
                if (oneO.Contains(letter))
                {
                    numOfOs++;
                }
                else if (twoO.Contains(letter))
                {
                    numOfOs += 2;
                }
            }

            return numOfOs;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            Console.WriteLine(GrawpOs(text));
            Console.ReadKey();
        }
    }
}
