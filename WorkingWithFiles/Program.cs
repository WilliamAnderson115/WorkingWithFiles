using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WorkingWithFiles
{
    // If you need to reference the files that are used for the tests, they are located in the
    // Solution Explorer inside the folder 'TextFiles'.

    public static class WorkingWithFiles
    {
        // 1- Write a method that reads a text file and returns the number of words. Ex. The file
        // contains, "The dog ran away from home." The method should return "6" the number of words
        // contained in the file. Return "0" for the word count if the file is empty.
        // .Trim() might be useful in this situation.
        public static int WordCount(string fileName)
        {
            int wordCount = 0;
            var path = @"C:\Users\wja96\Desktop\GitHubShop\WorkingWithFiles\WorkingWithFiles\" + fileName;
            var content = File.ReadAllLines(path);
            foreach(string word in content)
            {
                var test = word.Trim().Split(' ');
                foreach (string word2 in test)
                {
                    wordCount++;
                }
            }

            return wordCount;
        }

        // 2- Write a method that reads a text file and returns the longest word in the file. Ex.
        // The file contains, "The dog named Maximus ran away from home." The method should return
        // "Maximus" the longest word contained in the file. Return "File is Empty" if the file is empty.
        // .Trim() might be useful in this situation.
        public static string LongestWord(string fileName)
        {
            string LongestWord = "";

            var path = @"C:\Users\wja96\Desktop\GitHubShop\WorkingWithFiles\WorkingWithFiles\" + fileName;
            var content = File.ReadAllLines(path);
            foreach (string word in content)
            {
                var test = word.Trim().Split(' ');
                foreach (string word2 in test)
                {
                    if (word2.Length > LongestWord.Length)
                        LongestWord = word2;
                }
            }
            if (string.IsNullOrEmpty(LongestWord))
                LongestWord = "File is Empty";
            return LongestWord;
        }
    }

    public static class Program
    {
        public static void Main()
        {

        }
    }
}
