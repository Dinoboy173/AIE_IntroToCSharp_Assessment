﻿/*
 * Appendix 1 - Exercise 2: Fibonacci
 */

using System;

namespace AIE_Assessment_Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = 7;

            if (args.Length < 1) args = new string[] { "7" };

            numberOfElements = Int32.Parse(args[0]);

            // Write a function that will, given an integer n, calculate the first n numbers in the 
            // Fibonacci sequence given starting elements of (0, 1). 
            // Output your result to the console

            int[] seq = Fibinacci(numberOfElements);
            PrintArray(seq);
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static int[] Fibinacci(int numberOfElements)
        {
            int[] seq = new int[numberOfElements];
            seq[0] = 0;
            seq[1] = 1;

            for (int i = 2; i < numberOfElements; i++)
            {
                seq[i] = seq[i - 1] + seq[i - 2];
            }
            return seq;
        }
    }
}
