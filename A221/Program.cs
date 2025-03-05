using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A221
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Potion FelixFelicis = new Potion(192, 192, 192, 10);
            Potion PolyjuicePotion = new Potion(0, 128, 0, 5);
            Potion mixed = FelixFelicis.mix(PolyjuicePotion);

            List<int> mixedColour = mixed.getColour();
            Console.Write("Mixed potion colour: ");
            foreach (int colour in mixedColour)
            {
                Console.Write($"{colour} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Mixed potion volume: {mixed.getVolume()}");
            Console.ReadKey();
        }
    }
}
