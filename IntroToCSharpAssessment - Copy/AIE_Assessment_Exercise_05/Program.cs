/*
 * Appendix 2 - Exercise 2: Sorting an Array (Descending)
 */


using System;

namespace AIE_Assessment_Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input comma separated list of numbers");
            string lineOfText = Console.ReadLine();
            string[] values = lineOfText.Split(',');

            int[] numbers = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = Int32.Parse(values[i]);
            }

            // Write a function that accepts the integer array 'numbers' and outputs the sorted array to the console

            SortDecending(numbers);
            PrintArray(numbers);
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void SortDecending(int[] numbers)
        {
            bool isSorted = false;
            int lastUnsorted = numbers.Length - 1;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        //sort
                        int smallerNumber = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = smallerNumber;

                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }
        }
    }
}
