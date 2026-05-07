using System;
using System.Collections.Generic;
using System.IO;

namespace WordFrequencyCounterV1
{
    public class FileReader
    {
        public List<string> ReadFilesFromDirectory(string folderPath)
        {
            List<string> fileContents = new List<string>();

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Directory does not exist.");
                return fileContents;
            }

            string[] textFiles = Directory.GetFiles(folderPath, "*.txt");

            if (textFiles.Length == 0)
            {
                Console.WriteLine("No text files found in this directory.");
                return fileContents;
            }

            foreach (string file in textFiles)
            {
                try
                {
                    Console.WriteLine("Reading file: " + Path.GetFileName(file));
                    string content = File.ReadAllText(file);
                    fileContents.Add(content);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could not read file: " + file);
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return fileContents;
        }
    }
}