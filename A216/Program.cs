using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A216
{
    internal class Program
    {
        static string BPCCDecode(string text)
        {
            string[] splitSentences = text.Split(new char[] { '.', '!', '?' });
            for (int i = 0; i < splitSentences.Length; i++)
            {
                splitSentences[i] = splitSentences[i].Trim();
            }

            List<int> wordLengths = GetWordLengths(splitSentences[0]);
            string result = "";
            for (int i = 1; i < splitSentences.Length; i++)
            {
                string[] wordsInSentence = splitSentences[i].Split(' ');
                if (i - 1 < wordLengths.Count && wordLengths[i - 1] - 1 < wordsInSentence.Length)
                {
                    string target = wordsInSentence[wordLengths[i - 1] - 1];
                    result += target.Trim(',', '.', '?', '!') + " ";
                }
            }
            return result.Trim();
        }

        static List<int> GetWordLengths(string sentence)
        {
            List<int> wordLengths = new List<int>();
            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                wordLengths.Add(word.Replace(",", "").Replace("'", "").Length);
            }
            return wordLengths;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BPCCDecode("Yesterday, we bumped into Laura. It had to happen, but you can't deny the timing couldn't be worse. The mission to try and win her was a complete failure last month. By the way, she still has the diary I gave her. Anyhow, it hasn't been fun. I wanted to be done with it all."));
            Console.ReadKey();
        }
    }
}
