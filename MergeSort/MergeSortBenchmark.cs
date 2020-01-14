﻿using System.Linq;
using BenchmarkDotNet.Attributes;
using CommonHelpers;

namespace MergeSort
{
    public class MergeSortBenchmark
    {
        [Benchmark]
        public void Sort()
        {
            var numbers = HelperFunctions.GenerateIntegers(100).ToList();

            MergeSort.Sort(numbers);
        }
    }
}
