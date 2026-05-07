using System;
using System.Collections.Generic;

namespace WordFrequencyCounterV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WORD FREQUENCY COUNTER - VERSION 2");
            Console.WriteLine("-----------------------------------");

            Console.Write("Enter folder path containing .txt files: ");
            string folderPath = Console.ReadLine();

            Console.Write("N = word length limit\n");
            Console.Write("M = number of ending characters to remove\n\n");
            Console.Write("Enter N value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter M value: ");
            int m = Convert.ToInt32(Console.ReadLine());

            FileReader fileReader = new FileReader();
            TextProcessor textProcessor = new TextProcessor();
            WordCounter wordCounter = new WordCounter();

            List<string> fileContents = fileReader.ReadFilesFromDirectory(folderPath);
            List<string> allWords = new List<string>();

            foreach (string content in fileContents)
            {
                List<string> words = textProcessor.SplitIntoWords(content, n, m);
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