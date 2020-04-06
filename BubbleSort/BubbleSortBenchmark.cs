using BenchmarkDotNet.Attributes;
using CommonHelpers;

namespace BubbleSort
{
    [MemoryDiagnoser]
    public class BubbleSortBenchmark
    {
        [Benchmark]
        public void Sort()
        {
            var numbers = HelperFunctions.GenerateIntegers(100);

            BubbleSort.Sort(numbers);
        }

        [Benchmark]
        public void SortOrdered()
        {
            var numbers = HelperFunctions.GenerateIntegersOrdered(100);

            BubbleSort.Sort(numbers);
        }
    }
}
