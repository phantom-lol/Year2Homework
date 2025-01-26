using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A215
{
    internal class Program
    {
        static int BPCCDoorperson(string word)
        {
            int index = 0;
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    index = i + 1;
                    break;
                }
            }

            if (index > 0)
            {
                return index * 3;
            }
            else
            {
                return -1;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("help");
            Console.WriteLine(BPCCDoorperson("help"));
            Console.WriteLine("llamas");
            Console.WriteLine(BPCCDoorperson("llamas"));
            Console.ReadKey();
        }
    }
}
