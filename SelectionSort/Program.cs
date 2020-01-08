using System;
using BenchmarkDotNet.Running;
using CommonHelpers;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = HelperFunctions.GenerateIntegers(100);

            Console.WriteLine("unsorted: " + String.Join(",", numbers));
            SelectionSort.Sort(numbers);
            Console.WriteLine("sorted: " + String.Join(",", numbers));
            Console.WriteLine("*********************************************************");

            numbers = HelperFunctions.GenerateIntegers(100);

            Console.WriteLine("unsorted: " + String.Join(",", numbers));
            GenericSelectionSort<int>.Sort(numbers);
            Console.WriteLine("sorted: " + String.Join(",", numbers));

#if RELEASE
            BenchmarkRunner.Run<SortBenchmark>();
#endif
        }
    }
}
