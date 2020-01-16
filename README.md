# Algorithm demos

## Overview


| Algorithm        | Best-case           | Avg-case    | Worst-case   | Space |
| ---------------- |:-------------------:|:-----------:|:------------:|:------|
| Merge Sort       | O(n log n)          | O(n log n)  | O(n log n)   | O(n)  |
| Quick Sort       | O(n log n)          | O(n log n)  | O(n&#x00B2;) | O(n)  |
| Selection Sort   | O(n&#x00B2;)        | O(n&#x00B2;)| O(n&#x00B2;) | O(1)  |
| Insertion Sort   | O(n)                | O(n&#x00B2;)| O(n&#x00B2;) | O(n)  |

## Merge Sort

|                 Method |     Mean |   Error |  StdDev |
|----------------------- |---------:|--------:|--------:|
|         SortRandomized | 112.2 us | 2.21 us | 3.87 us |
| SortWhenAlreadyOrdered | 113.2 us | 2.26 us | 6.26 us |

## Quick Sort

|                                Method |       Mean |    Error |   StdDev |
|-------------------------------------- |-----------:|---------:|---------:|
|  Sort_LastItemAsPivot_RandomizedArray | 5,713.9 ns | 61.05 ns | 54.12 ns |
| Sort_PivotInTheMiddle_RandomizedArray | 6,581.6 ns | 80.51 ns | 71.37 ns |
|     Sort_LastItemAsPivot_OrderedArray | 6,211.7 ns | 64.89 ns | 57.52 ns |
|    Sort_PivotInTheMiddle_OrderedArray |   728.6 ns |  9.49 ns |  8.88 ns |

## Selection Sort

|           Method |     Mean |    Error |   StdDev |
|----------------- |---------:|---------:|---------:|
|        SortArray | 18.86 us | 0.292 us | 0.273 us |
| GenericSortArray | 44.52 us | 0.869 us | 1.428 us |

## Insertion Sort

|      Method |       Mean |     Error |    StdDev |
|------------ |-----------:|----------:|----------:|
|        Sort | 5,958.8 ns | 117.75 ns | 209.30 ns |
| SortOrdered |   221.1 ns |   4.42 ns |  12.18 ns |