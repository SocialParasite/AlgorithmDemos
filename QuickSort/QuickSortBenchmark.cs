using BenchmarkDotNet.Attributes;
using CommonHelpers;

namespace QuickSort
{
    [MemoryDiagnoser]
    public class QuickSortBenchmark
    {
        [Benchmark]
        public void SortArray()
        {
            var numbers = HelperFunctions.GenerateIntegers(100);

            QuickSort.Sort(numbers, 0, numbers.Length-1);
        }

        [Benchmark]
        public void SortArray2()
        {
            var numbers = HelperFunctions.GenerateIntegers(100);

            QuickSort.Sort2(numbers, 0, numbers.Length - 1);
        }

        [Benchmark]
        public void SortArrayWithOrderedArray()
        {
            var numbers = HelperFunctions.GenerateIntegersOrdered(100);

            QuickSort.Sort(numbers, 0, numbers.Length - 1);
        }

        [Benchmark]
        public void SortArray2WithOrderedArray()
        {
            var numbers = HelperFunctions.GenerateIntegersOrdered(100);

            QuickSort.Sort2(numbers, 0, numbers.Length - 1);
        }
    }
}
