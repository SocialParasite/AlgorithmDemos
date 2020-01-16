using BenchmarkDotNet.Attributes;
using CommonHelpers;

namespace QuickSort
{
    [MemoryDiagnoser]
    public class QuickSortBenchmark
    {
        [Benchmark]
        public void Sort_LastItemAsPivot_RandomizedArray()
        {
            var numbers = HelperFunctions.GenerateIntegers(100);

            QuickSort.Sort(numbers, 0, numbers.Length-1);
        }

        [Benchmark]
        public void Sort_PivotInTheMiddle_RandomizedArray()
        {
            var numbers = HelperFunctions.GenerateIntegers(100);

            QuickSort.Sort2(numbers, 0, numbers.Length - 1);
        }

        [Benchmark]
        public void Sort_LastItemAsPivot_OrderedArray()
        {
            var numbers = HelperFunctions.GenerateIntegersOrdered(100);

            QuickSort.Sort(numbers, 0, numbers.Length - 1);
        }

        [Benchmark]
        public void Sort_PivotInTheMiddle_OrderedArray()
        {
            var numbers = HelperFunctions.GenerateIntegersOrdered(100);

            QuickSort.Sort2(numbers, 0, numbers.Length - 1);
        }
    }
}
