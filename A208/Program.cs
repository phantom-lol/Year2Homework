using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace A208
{
    internal class Program
    {
        static bool feast(string name, string dish)
        {
            HashSet<char> result = new HashSet<char>();
            result.Add(name[0]);
            result.Add(name[name.Length - 1]);
            if (result.Add(dish[0]) == false && result.Add(dish[dish.Length - 1]) == false)
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
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter dish:");
            string dish = Console.ReadLine();
            Console.WriteLine(feast(name.ToLower(), dish.ToLower()));
            Console.ReadKey();
        }
    }
}
