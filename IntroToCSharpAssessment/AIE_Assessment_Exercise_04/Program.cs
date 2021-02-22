/*
 * Appendix 2 - Exercise 1: Sum of Array
 */

using System;

namespace AIE_Assessment_Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0,1,2,3");
            string lineOfText = Console.ReadLine();
            string[] values = lineOfText.Split(',');

            int[] numbers = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = Int32.Parse(values[i]);
            }

            // TODO:
            // Write a function that accepts the integer array 'numbers' and 
            // returns the sum of the array
        }

        static int Sum(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length; i++)
            {

            }
        }
    }
}
