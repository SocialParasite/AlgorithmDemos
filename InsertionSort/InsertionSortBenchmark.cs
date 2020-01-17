using BenchmarkDotNet.Attributes;
using CommonHelpers;

namespace InsertionSort
{
    [MemoryDiagnoser]
    public class InsertionSortBenchmark
    {
        [Benchmark]
        public void Sort()
        {
            var numbers = HelperFunctions.GenerateIntegers(100);

            InsertionSort.Sort(numbers);
        }

        [Benchmark]
        public void SortOrdered()
        {
            var numbers = HelperFunctions.GenerateIntegersOrdered(100);

            InsertionSort.Sort(numbers);
        }
    }
}
