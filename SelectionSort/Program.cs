using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] numbers = { 55, 20, 74, 46, 71, 63 };

                Console.WriteLine("unsorted: " + String.Join(",", numbers));
                SelectionSort.Sort(numbers);
                Console.WriteLine("sorted: " + String.Join(",", numbers));
                Console.WriteLine("*********************************************************");

                numbers = new int[] { 55, 20, 74, 46, 71, 63 };

                Console.WriteLine("unsorted: " + String.Join(",", numbers));
                GenericSelectionSort<int>.Sort(numbers);
                Console.WriteLine("sorted: " + String.Join(",", numbers));

#if RELEASE
            BenchmarkRunner.Run<SortBenchmark>();
#endif
            }
        }
    }
}
