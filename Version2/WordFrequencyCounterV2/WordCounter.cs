using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFrequencyCounterV2
{
    public class WordCounter
    {
        public Dictionary<string, int> CountWords(List<string> words)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            return wordFrequency;
        }

        public void DisplayResults(Dictionary<string, int> wordFrequency)
        {
            Console.WriteLine();
            Console.WriteLine("Word Frequency Results");
            Console.WriteLine("----------------------");

            foreach (var item in wordFrequency.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}