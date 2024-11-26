using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace A209
{
    internal class Program
    {
        static string StableEquilibrium(string num)
        {
            string output = "";
            foreach (var digit in num)
            {
                switch (digit)
                {
                    case '0':
                        output += "zero";
                        break;
                    case '1':
                        output += "one";
                        break;
                    case '2':
                        output += "two";
                        break;
                    case '3':
                        output += "three";
                        break;
                    case '4':
                        output += "four";
                        break;
                    case '5':
                        output += "five";
                        break;
                    case '6':
                        output += "six";
                        break;
                    case '7':
                        output += "seven";
                        break;
                    case '8':
                        output += "eight";
                        break;
                    case '9':
                        output += "nine";
                        break;

                    default:
                        break;
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string num = Console.ReadLine();
            string output = StableEquilibrium(num);

            do
            {
                if (output != "four")
                {
                    Console.WriteLine(output);
                    output = StableEquilibrium(output.Length.ToString());
                }

            } while (output != "four");

            Console.WriteLine("four");

            Console.ReadKey();
        }

    }
}
