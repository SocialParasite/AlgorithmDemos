using System;
using BenchmarkDotNet.Running;
using CommonHelpers;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = HelperFunctions.GenerateIntegers(100);


            Console.WriteLine("unsorted: " + String.Join(",", numbers));
            BubbleSort.Sort(numbers);

            Console.WriteLine();

            Console.WriteLine("sorted: " + String.Join(",", numbers));
            Console.WriteLine("*********************************************************");

#if RELEASE
            BenchmarkRunner.Run<BubbleSortBenchmark>();
#endif
        }
    }
}
