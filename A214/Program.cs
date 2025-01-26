using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A214
{
    internal class Program
    {
        static int BasicMaths(string input)
        {
            List<int> nums = new List<int>();
            List<char> operators = new List<char>();
            nums.Add((int)input[0]);
            for (int i = 1; i < input.Length - 1; i++)
            {
                if (input[i] == 'm')
                {
                    operators.Add('-');
                    i += 5;
                }
                else if (input[i] == 'p')
                {
                    operators.Add('+');
                    i += 4;
                }
                else
                {
                    nums.Add((int)input[i]);
                }
            }
            nums.Add((int)input[input.Length - 1]);

            int result = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (operators[i] == '+')
                {
                    result += nums[i] + nums[i + 1];
                }
                else
                {
                    result += nums[i] - nums[i + 1];
                }
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string input = Console.ReadLine();
            Console.WriteLine(BasicMaths(input));
            Console.ReadKey();
        }
    }
}
