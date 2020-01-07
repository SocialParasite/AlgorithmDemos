using System;
using BenchmarkDotNet.Running;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 55, 20, 74, 46, 71, 63 };

            Console.WriteLine("unsorted: " + String.Join(",", numbers));
            QuickSort.Sort(numbers, 0, numbers.Length-1);

            Console.WriteLine("sorted: " + String.Join(",", numbers));
            Console.WriteLine("*********************************************************");

#if RELEASE
            BenchmarkRunner.Run<SortBenchmark>();
#endif
        }
    }
}
