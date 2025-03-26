using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A224
{
    class Program
    {
        static bool automorphic(int num)
        {
            double temp = Math.Pow(num, 2);
            return temp.ToString()[temp.ToString().Length - 1] == num.ToString()[num.ToString().Length - 1];
        }

        static int consonants(string input)
        {
            int total = 0;
            foreach (char a in input)
            {
                if (vowels(a.ToString()) == 0 && (int)a >= 97 && (int)a <= 122)
                {
                    total++;
                }
            }
            return total;
        }

        static int vowels(string input)
        {
            input = input.ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int total = 0;
            foreach (char a in input)
            {
                if (vowels.Contains(a))
                {
                    total++;
                }
            }
            return total;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(automorphic(225));
            Console.WriteLine(automorphic(376));
            Console.WriteLine(automorphic(5));
            Console.WriteLine($"{vowels("It matters not what someone is born, but what they grow to be.")} {consonants("It matters not what someone is born, but what they grow to be.")}");
            Console.ReadKey();
        }
    }
}
