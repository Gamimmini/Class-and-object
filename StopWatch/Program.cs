using System;
using System.Diagnostics;

namespace StopwatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(100000);
            StopWatch StopWatch = new StopWatch();
            SelectionSort(numbers);
            StopWatch.Stop();
            Console.WriteLine("Elapsed Time: " + StopWatch.GetElapsedTime() + " ms");
        }

        static int[] GenerateNumbers(int count)
        {
            int[] numbers = new int[count];
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next();
            }
            return numbers;
        }

        static void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}