using System;
using System.Linq;
using BenchmarkDotNet.Running;
using CommonHelpers;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = HelperFunctions.GenerateIntegers(100).ToList();

            Console.WriteLine("unsorted: " + String.Join(",", numbers));

            var test = MergeSort.Sort(numbers);

            Console.WriteLine();

            Console.WriteLine("sorted: " + String.Join(",", test));

            Console.WriteLine("*********************************************************");

#if RELEASE
            BenchmarkRunner.Run<MergeSortBenchmark>();
#endif
        }
    }
}
