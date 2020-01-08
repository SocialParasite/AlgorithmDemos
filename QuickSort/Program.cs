using System;
using BenchmarkDotNet.Running;
using CommonHelpers;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = HelperFunctions.GenerateIntegers(100);
            //var numbers = HelperFunctions.GenerateIntegersOrdered(100);

            Console.WriteLine("unsorted: " + String.Join(",", numbers));
            //QuickSort.Sort(numbers, 0, numbers.Length-1);
            QuickSort.Sort2(numbers, 0, numbers.Length - 1);

            Console.WriteLine();

            Console.WriteLine("sorted: " + String.Join(",", numbers));
            Console.WriteLine("*********************************************************");

#if RELEASE
            BenchmarkRunner.Run<SortBenchmark>();
#endif
        }
    }
}
