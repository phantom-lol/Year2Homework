using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace A211
{
    internal class Program
    {
        static int P1(string input)
        {
            string[] lines = input.Trim().Split('\n');
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            foreach (string line in lines)
            {
                char[] whitespace = { ' ', '\t' };
                string[] numbers = line.Split(whitespace, StringSplitOptions.RemoveEmptyEntries);
                left.Add(int.Parse(numbers[0]));
                right.Add(int.Parse(numbers[1]));
            }
            left.Sort();
            right.Sort();
            int result = 0;
            for (int i = 0; i < left.Count; i++)
            {
                if (left[i] > right[i])
                {
                    result += left[i] - right[i];
                }
                else
                {
                    result += right[i] - left[i];
                }
            }
            return result;
        }

        static int P2(string input)
        {
            string[] lines = input.Trim().Split('\n');
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            foreach (string line in lines)
            {
                char[] whitespace = { ' ', '\t' };
                string[] numbers = line.Split(whitespace, StringSplitOptions.RemoveEmptyEntries);
                left.Add(int.Parse(numbers[0]));
                right.Add(int.Parse(numbers[1]));
            }

            int answer = 0;
            for (int i = 0; i < left.Count; i++)
            {
                int amount = 0;
                for (int j = 0; j < right.Count; j++)
                {
                    if (left[i] == right[j])
                    {
                        amount++;
                    }
                }
                answer += left[i] * amount;
            }
            return answer;
        }

        static void Main(string[] args)
        {
            // solution to part 1 and 2 of first day of AOC
            string input = File.ReadAllText("input.txt");
            Console.WriteLine($"Solution 1: {P1(input)}\nSolution 2: {P2(input)}");
            Console.ReadKey();
        }
    }
}
