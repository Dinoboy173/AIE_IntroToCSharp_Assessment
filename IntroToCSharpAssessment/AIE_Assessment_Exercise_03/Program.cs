/*
 * Appendix1 - Exercise 3: FizzBuzz
 */

using System;

namespace AIE_Assessment_Exercise_03
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
            // Write a function to generate output according to the FizzBuzz project brief
            // The function must print the appropriate response for each value i in the 
            // set {1, 2, ... n} in ascending order, each on a separate line
        }
    }
}
