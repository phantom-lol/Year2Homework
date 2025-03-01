﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A220
{
    internal class Program
    {
        
        static void HaikuGenerator(string[,] words)
        {
            Random rnd = new Random();
            bool validHaiku = false;
            List<Array> result = new List<Array>();
            while (!validHaiku)
            {
                for (int i = 0; i < 3; i++)
                {
                    bool validLine = false;
                    string[] line = new string[3];
                    int totalSyllables = 0;
                    while (!validLine)
                    {
                        if (i == 1)
                        {
                            int syllables = rnd.Next(1, 8);
                            int wordIndex = rnd.Next(1, 10);
                            line[i] = words[syllables, wordIndex];
                            totalSyllables += syllables;
                            validLine = totalSyllables <= 7;
                        }
                        else
                        {
                            int syllables = rnd.Next(1, 6);
                            int wordIndex = rnd.Next(1, 10);
                            line[i] = words[syllables, wordIndex];
                            totalSyllables += syllables;
                            validLine = totalSyllables <= 5;
                        }
                    }
                    result.Add(line);
                }
                validHaiku = HaikuChecker(words, result);
            }
            
            PrintHaiku(result);
        }

        static void PrintHaiku(List<Array> result)
        {
            for (int i = 0; i < result.Count; i++)
            {
                Array array = result[i];
                foreach (string word in array)
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadKey();
        }

        static bool HaikuChecker(string[,] words, List<Array> list)
        {
            List<int> syllables = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                int totalSyllables = 0;
                foreach (string word in list[i])
                {
                    char[] letters = word.ToCharArray();
                    totalSyllables += int.Parse(letters[0].ToString());
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

            HaikuGenerator(words);
            Console.ReadKey();
        }
    }
}
