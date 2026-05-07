using System;
using System.Collections.Generic;

namespace WordFrequencyCounterV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WORD FREQUENCY COUNTER - VERSION 1");
            Console.WriteLine("-----------------------------------");

            Console.Write("Enter folder path containing .txt files: ");
            string folderPath = Console.ReadLine();

            FileReader fileReader = new FileReader();
            TextProcessor textProcessor = new TextProcessor();
            WordCounter wordCounter = new WordCounter();

            List<string> fileContents = fileReader.ReadFilesFromDirectory(folderPath);
            List<string> allWords = new List<string>();

            foreach (string content in fileContents)
            {
                List<string> words = textProcessor.SplitIntoWords(content);
                allWords.AddRange(words);
            }

            Dictionary<string, int> result = wordCounter.CountWords(allWords);

            wordCounter.DisplayResults(result);

            Console.WriteLine();
            Console.WriteLine("Program finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
