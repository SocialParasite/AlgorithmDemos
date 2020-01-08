using BenchmarkDotNet.Attributes;
using CommonHelpers;

namespace SelectionSort
{
    [MemoryDiagnoser]
    public class SortBenchmark
    {
        [Benchmark]
        public void SortArray()
        {
            var numbers = HelperFunctions.GenerateIntegers(100);

            SelectionSort.Sort(numbers);
        }

        [Benchmark]
        public void GenericSortArray()
        {
            var numbers = HelperFunctions.GenerateIntegers(100);

            GenericSelectionSort<int>.Sort(numbers);
        }
    }
}
