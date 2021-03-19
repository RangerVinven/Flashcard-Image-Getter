using System;
using System.IO;

namespace flashcardImageGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opens the words
            string[] words = File.ReadAllLines("C:\\Users\\User\\Documents\\2000GermanWords.txt");

            // Loops through the words and finds the ones with "the "
            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].Contains("The ")) {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
