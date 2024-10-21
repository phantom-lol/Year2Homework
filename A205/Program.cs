using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A205
{
    internal class Program
    {
        static bool HappyNumberTest(int num)
        {
            HashSet<int> numbers = new HashSet<int>();
            while (num != 1 && !numbers.Contains(num))
            {
                numbers.Add(num);
                int sum = 0;
                while (num > 0)
                {
                    int digit = num % 10;
                    sum += digit * digit;
                    num = num / 10;
                }

                num = sum;
            }
            
            if (num == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(HappyNumberTest(a));
            Console.ReadKey();
        }
    }
}
