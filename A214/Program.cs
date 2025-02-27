using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A214
{
    internal class Program
    {
        //static int BasicMaths(string input)
        //{
        //    int result = int.Parse(input[0].ToString());
        //    for (int i = 1; i < input.Length - 1; i++)
        //    {
        //        if (input[i] == 'p')
        //        {
        //            result += int.Parse(input[i + 4].ToString());
        //        }
        //        else if (input[i] == 'm')
        //        {
        //            result -= int.Parse(input[i + 5].ToString());
        //        }
        //    }
        //    return result;
        //}

        static bool calculateWinner(int currentAttacker, int currentDefender)
        {
            int survivedAttackers = 0, survivedDefenders = 0;
            if (currentAttacker > currentDefender)
            {
                survivedAttackers++;
            }
            else if (currentDefender > currentAttacker)
            {

            }
        } 
            nums.Add((int)input[input.Length - 1]);
        
        static bool attacked(int[] attackers, int[] defenders)
        {
            bool result = false;
            if (attackers.Count() > defenders.Count() || attackers.Count() == defenders.Count())
            {
                for (int i = 0; i < attackers.Count(); i++)
                {
                    result = calculateWinner(attackers[i], defenders[i]);
                }
            }
            else
            {
                for (int i = 0; i < defenders.Count(); i++)
                {
                    result = calculateWinner(attackers[i], defenders[i]);
                }
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            int[] attackers = { 1, 3, 5, 7 };
            int[] defenders = { 2, 4, 6, 8 };
            bool result = attacked(attackers, defenders);
            if (result == true) Console.WriteLine("You survived the attack!!");
            else Console.WriteLine("You all perish");
            Console.ReadKey();
        }
    }
}
