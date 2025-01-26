using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A213
{
    internal class Program
    {
        // idk kinda gives christmas lights but not really 
        static ConsoleColor RandomColour()
        {
            Random rnd = new Random();
            switch (rnd.Next(1,4))
            {
                case 1:
                    return ConsoleColor.Red;
                case 2:
                    return ConsoleColor.Green;
                case 3:
                    return ConsoleColor.Cyan;
                case 4:
                    return ConsoleColor.Magenta;
            }

            return ConsoleColor.Yellow;
        }

        static void CreateTree(int num)
        {
            int numOfLevels = num / 3;
            int maxStars = 5;
            for (int i = 1; i < numOfLevels; i++)
            {
                maxStars += 2;
            }

            int numOfStars = 1;
            int row = 1;
            int carriedNum = 0;
            for (int i = 0; i < numOfLevels; i++)
            {
                while (row <= 3)
                {
                    Console.CursorLeft = maxStars - (numOfStars / 2);
                    for (int j = 0; j < numOfStars - 1; j++)
                    {
                        Console.ForegroundColor = RandomColour(); 
                        Console.Write("*");
                        Console.ResetColor();
                    }
                    Console.ForegroundColor = RandomColour();
                    Console.WriteLine("*");
                    Console.ResetColor();

                    if (row == 2)
                    {
                        carriedNum = row;
                    }
                    row++;
                    numOfStars += 2;
                }

                row = 1;
                numOfStars -= 4;
            }

            Console.CursorLeft = maxStars - 1;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("#");
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter christmas tree number:");
            CreateTree(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
