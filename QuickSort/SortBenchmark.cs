using BenchmarkDotNet.Attributes;

namespace QuickSort
{
    [MemoryDiagnoser]
    public class SortBenchmark
    {
        [Benchmark]
        public void SortArray()
        {
            int[] numbers = { 55, 20, 74, 46, 71, 63 };

            QuickSort.Sort(numbers, 0, numbers.Length-1);
        }
    }
}
