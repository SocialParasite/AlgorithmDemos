using BenchmarkDotNet.Attributes;
using CommonHelpers;

namespace QuickSort
{
    [MemoryDiagnoser]
    public class SortBenchmark
    {
        [Benchmark]
        public void SortArray()
        {
            var numbers = HelperFunctions.GenerateIntegers(100);

            QuickSort.Sort(numbers, 0, numbers.Length-1);
        }
    }
}
