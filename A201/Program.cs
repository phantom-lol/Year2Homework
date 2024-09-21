using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A201
{
    internal class Program
    {
        static string FinalMap(string startMap)
        {
            string newMap = "";
            bool infected = false;
            int continentNum = 0;
            foreach (char character in startMap)
            {
                if (character == 'X')
                {
                    for (int i = 0; i < continentNum; i++)
                    {
                        if (infected == true)
                        {
                            newMap += 1;
                        }
                        else
                        {
                            newMap += 0;
                        }
                    }

                    newMap += 'X';
                    continentNum = 0;
                    infected = false;
                }
                else
                {
                    if (character == '1')
                    {
                        infected = true;
                    }
                    continentNum++;
                }
            }

            return newMap;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter start map: ");
            string map = Console.ReadLine();
            int population = 0, infected = 0;

            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] == '0')
                {
                    population++;
                }
                else if (map[i] == '1')
                {
                    infected++;
                    population++;
                }
                else
                {
                    continue;
                }
            }
            int percent = 100 * infected / population;
            Console.WriteLine("Final Map: " + FinalMap(map));
            Console.WriteLine("Total population: " + population);
            Console.WriteLine("Number infected: " + infected);
            Console.WriteLine($"Total Percentage of world infected is: {percent}%");
            Console.ReadKey();
        }
    }
}
