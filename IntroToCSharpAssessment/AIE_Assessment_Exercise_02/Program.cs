/*
 * Appendix 1 - Exercise 2: Fibonacci
 */

using System;

namespace AIE_Assessment_Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = 0;

            if (args.Length < 1)
            {
                Console.WriteLine("Insufficient input arguments.");
                return;
            }

            numberOfElements = Int32.Parse(args[0]);

            // TODO:
            // Write a function that will, given an integer n, calculate the first n numbers in the 
            // Fibonacci sequence given starting elements of (0, 1). 
            // Output your result to the console
        }
    }
}
