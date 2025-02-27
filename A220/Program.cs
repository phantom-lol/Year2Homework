using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A220
{
    internal class Program
    {
        static string HaikuGenerator(string[,] words)
        {
            Random rnd = new Random();
            bool validHaiku = false;
            while (!validHaiku)
            {
                bool validLine = false;
                List<string> line1 = new List<string>();
                int totalSyllablesInLine = 0;
                while (!validLine)
                {
                    
                }
            }
        }
        
        static bool HaikuChecker(string[,] words, string[] line1, string[] line2, string[] line3)
        {
            List<Array> list = new List<Array>();
            list.Add(line1); list.Add(line2); list.Add(line3);
            List<int> syllables = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                int totalSyllables = 0;
                foreach (string word in list[i])
                {
                    char[] digits = word.ToCharArray();
                    totalSyllables += int.Parse(digits[0].ToString());
                }
                syllables.Add(totalSyllables);
            }

            return syllables[0] == 5 && syllables[1] == 7 && syllables[2] == 5;
        }
        
        static void Main(string[] args)
        {
            string[,] words = {{"like", "a", "the", "what", "for", "world", "whale", "one", "last" },
            {"ocean", "beauty", "tweet", "monster", "yellow", "return", "despair", "flower", "return"},
            {"romantic", "curious", "banana", "jealousy", "tactlessly", "remorseful", "follower", "elephant", "however" },
            { "salmonella", "consequently", "irregular", "intelligence", "vegetable", "ordinary", "alternative", "watermelon", "controversial"},
            {"lackadaisical", "serendipity", "colonoscopy", "dramatically", "parsimonious", "imagination", "electricity", "diabolical", "deforestation"},
            {"extraterrestrial", "onomatopoeia", "responsibility", "revolutionary", "generalisation", "enthusiastically", "biodiversity", "veterinarian", "characteristically"},
            {"oversimplification", "individuality", "decriminalisation", "compartmentalisation", "anaesthesiologist", "industrialisation", "buckminsterfullerene", "irresponsibility", "autobiographical"}};

            string[] line1 = { "16", "28", "23" };
            string[] line2 = { "24" };
            string[] line3 = { "19", "45" };

            Console.WriteLine(HaikuChecker(words, line1, line2, line3));
            Console.ReadKey();
        }
    }
}
