using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A203
{
    internal class Program
    {
        static bool binarySearch(int[] array, int search)
        {
            int rear, front;
            rear = 0;
            front = array.Length - 1;

            while (rear <= front)
            {
                int mid = (front + rear) / 2;

                if (array[mid] == search)
                {
                    return true;
                }
                else
                {
                    if (array[mid] < search)
                    {
                        rear = mid + 1;
                    }
                    else
                    {
                        front = mid - 1;
                    }
                }
            }

            return false;
        }
        
        static void Main(string[] args)
        {
            int[] a = { 2, 6, 14, 24, 39, 57, 63, 88 };

            //if (binarySearch(a, 63) == true)
            //{
            //    Console.WriteLine("found");
            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}

            if (binarySearch(a, 65) == true)
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.ReadKey();
        }
    }
}
