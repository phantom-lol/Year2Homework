using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A221
{
    public class Potion
    {
        protected List<int> colour = new List<int>();
        protected int volume;

        public Potion(int red, int green, int blue, int volume)
        {
            colour.Add(red); colour.Add(green); colour.Add(blue);
            this.volume = volume;
        }

        public List<int> getColour() { return colour; }
        public int getVolume() { return volume; }

        public Potion mix(Potion secondPotion)
        {
            int firstPotionVolume = getVolume();
            int secondPotionVolume = secondPotion.getVolume();
            List<int> secondPotionColour = secondPotion.getColour();
            for (int i = 0; i < colour.Count; i++)
            {
                int firstColour = colour[i];
                int secondColour = secondPotionColour[i];
                secondPotion.colour[i] = (firstColour * firstPotionVolume + secondColour * secondPotionVolume) / (firstPotionVolume + secondPotionVolume);
            }
            secondPotion.volume = firstPotionVolume + secondPotionVolume;
            return secondPotion;
        }
    }
}
