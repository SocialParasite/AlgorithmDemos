using BenchmarkDotNet.Attributes;

namespace SelectionSort
{
    [MemoryDiagnoser]
    public class SortBenchmark
    {
        [Benchmark]
        public void SortArray()
        {
            SelectionSort.Sort(new int[] { 55, 20, 74, 46, 71, 63 });
        }

        [Benchmark]
        public void GenericSortArray()
        {
            GenericSelectionSort<int>.Sort(new int[] { 55, 20, 74, 46, 71, 63 });
        }
    }
}
