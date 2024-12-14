using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A212
{
    internal class Program
    {
        static int stickyCalc(char op, double first, double second)
        {
            if (first < 0 || second < 0)
            {
                Console.WriteLine("You can only enter positive integers");
                return 0;
            }

            double firstRounded = Math.Round(first);
            double secondRounded = Math.Round(second);

            string stuck = firstRounded.ToString() + secondRounded.ToString();
            int num1 = int.Parse(stuck);
            int num2 = Convert.ToInt32(second);
            int answer = 0;
            switch (op)
            {
                case '+':
                    answer = num1 + num2; break;
                case '-':
                    answer = num1 - num2; break;
                case '*':
                    answer = num1 * num2; break;
                case '/':
                    double temp = 0;
                    temp = double.Parse(stuck) / secondRounded;
                    temp = Math.Round(temp);
                    answer = Convert.ToInt32(temp);
                    break;

            }
            return answer;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter operation: ");
            char op = char.Parse(Console.ReadLine());
            Console.Write("Enter first value: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second value: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = stickyCalc(op, num1, num2);
            Console.WriteLine(result); Console.ReadKey();
        }
    }
}
