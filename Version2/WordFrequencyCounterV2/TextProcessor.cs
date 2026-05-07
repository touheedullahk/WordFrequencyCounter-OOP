using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordFrequencyCounterV2
{
    public class TextProcessor
    {
        public List<string> SplitIntoWords(string text, int n, int m)
        {
            List<string> wordsList = new List<string>();

            string[] words = Regex.Split(text.ToLower(), @"[\s\p{P}]+");

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    string processedWord = RemoveEnding(word, n, m);
                    wordsList.Add(processedWord);
                }
            }

            return wordsList;
        }

        private string RemoveEnding(string word, int n, int m)
        {
            if (word.Length > n && word.Length > m)
            {
                return word.Substring(0, word.Length - m);
            }

            return word;
        }
    }
}