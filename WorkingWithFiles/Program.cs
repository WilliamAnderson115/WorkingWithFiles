using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WorkingWithFiles
{
    public static class WorkingWithFiles
    {
        // 1- Write a method that reads a text file and returns the number of words. Ex. The file
        // contains, "The dog ran away from home." The method should return "6" the number of words
        // contained in the file.
        public static int WordCount(string fileName)
        {
            int result = 0;
            string subFolder = "TextFiles";
            fileName = "Exercise_8_Text_File.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, subFolder, fileName);
            StreamReader sr = new StreamReader(filePath);
            //var blah = File.ReadAllText(fileName)

            
            // Delete the below line when you are writing your code 
            return result;
        }

        // 2- Write a method that reads a text file and returns the longest word in the file. Ex.
        // The file contains, "The dog named Maximus ran away from home." The method should return
        // "Maximus" the longest word contained in the file.
        public static string LongestWord()
        {
            // Delete the below line when you are writing your code 
            return default;
        }
    }

    public static class Program
    {
        public static void Main()
        {
            string subFolder = "TextFiles";
            string fileName = "Cheese.txt";

            string filePath = Path.Combine(Directory.GetCurrentDirectory().ToString(), subFolder, fileName);

            var existsOrNot = File.Exists(filePath);
            Console.WriteLine(filePath);
            Console.WriteLine(existsOrNot);

            var blah = File.ReadAllText(filePath);
            var blah2 = File.ReadAllLines(filePath);
            var words = 0;
            foreach (var item in blah2)
            {
                    var number = item.Split(" ").Length;
                words += number;
            }
            Console.WriteLine(words);

            //string jasfhg = "word";
            //var answer = jasfhg.Split(" ").Length;

            //Console.WriteLine(answer);
        }
    }
}
