using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordFrequencyCounterV1
{
    public class TextProcessor
    {
        public List<string> SplitIntoWords(string text)
        {
            List<string> wordsList = new List<string>();

            string[] words = Regex.Split(text.ToLower(), @"[\s\p{P}]+");

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    wordsList.Add(word);
                }
            }

            return wordsList;
        }
    }
}