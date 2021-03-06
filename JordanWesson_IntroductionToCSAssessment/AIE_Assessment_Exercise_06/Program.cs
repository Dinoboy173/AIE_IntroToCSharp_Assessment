﻿/*
 * Appendix 3 - Exercise 1: Alphabetize a File
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace AIE_Assessment_Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = LoadWords("words.txt");
            words = SortWords(words);
            SaveWords(words, "output.txt");
        }

        public static List<string> LoadWords(string filename)
        {
            using (StreamReader sr = File.OpenText(filename))
            {
                string line;
                List<string> words = new List<string>();
                sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line);
                }
                return words;
            }
        }

        public static List<string> SortWords(List<string> words)
        {
            // create copy of words list
            List<string> sortedWords = new List<string>(words);

            // sort the copy
            sortedWords.Sort();

            // return the copy
            return sortedWords;
        }

        public static void SaveWords(List<string> words, string filename)
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                for (int i = 0; i < words.Count; i++)
                {
                    sw.WriteLine(words[i]);
                }
            }
        }
    }
}
