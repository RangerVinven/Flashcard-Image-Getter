using System;
using System.Collections.Generic;
using System.IO;

namespace flashcardImageGetter
{
    class Program
    {

        public static List<string> getNouns(string path)
        {
            // Opens the words
            string[] words = File.ReadAllLines(path);

            // Loops through the words and finds the ones with "The " (for nouns) and appends them to the nouns list
            List<string> nouns = new List<string> { };
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains("The "))
                {
                    nouns.Add(words[i].Replace("The ", "").Trim());
                }
            }

            foreach (string noun in nouns)
            {
                Console.WriteLine(noun);
            }

            return nouns;
        }

        public static void writeNouns(List<string> nouns)
        {

        }

        static void Main(string[] args)
        {
            List<string> nouns = getNouns("C:\\Users\\User\\Documents\\2000GermanWords");
            writeNouns(nouns);

        }
    }
}
