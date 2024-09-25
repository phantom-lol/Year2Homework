using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A202
{
    internal class Program
    {
        static void bubbleSort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            int[] A = { 93, 46, 85, 90, 66, 57, 75, 5, 33, 45 };
            bubbleSort(A);
        }
    }
}
