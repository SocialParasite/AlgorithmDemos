using System;
using BenchmarkDotNet.Running;
using CommonHelpers;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = HelperFunctions.GenerateIntegers(100);
            //var numbers = HelperFunctions.GenerateIntegersOrdered(100);

            Console.WriteLine("unsorted: " + String.Join(",", numbers));
            InsertionSort.Sort(numbers);

            Console.WriteLine();

            Console.WriteLine("sorted: " + String.Join(",", numbers));
            Console.WriteLine("*********************************************************");

#if RELEASE
            BenchmarkRunner.Run<InsertionSortBenchmark>();
#endif
        }
    }
}
