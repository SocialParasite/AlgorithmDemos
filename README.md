# Algorithm demos

## Overview


| Algorithm        | Best-case           | Avg-case    | Worst-case   | Space |
| ---------------- |:-------------------:|:-----------:|:------------:|:------|
| Merge Sort       | O(n log n)          | O(n log n)  | O(n log n)   | O(n)  |
| Quick Sort       | O(n log n)          | O(n log n)  | O(n&#x00B2;) | O(n)  |
| Selection Sort   | O(n&#x00B2;)        | O(n&#x00B2;)| O(n&#x00B2;) | O(1)  |
| Insertion Sort   | O(n)                | O(n&#x00B2;)| O(n&#x00B2;) | O(n)  |
| Bubble Sort      | O(n)                | O(n&#x00B2;)| O(n&#x00B2;) | O(1)  |

## Merge Sort

| Method |     Mean |   Error |  StdDev | Allocated |
|------- |---------:|--------:|--------:|----------:|
|   Sort | 124.0 us | 2.43 us | 2.80 us | 126.21 KB |

## Quick Sort

|                                Method |       Mean |     Error |    StdDev | Allocated |
|-------------------------------------- |-----------:|----------:|----------:|----------:|
|  Sort_LastItemAsPivot_RandomizedArray | 5,762.1 ns | 110.89 ns | 151.79 ns |     704 B |
| Sort_PivotInTheMiddle_RandomizedArray | 6,632.4 ns | 122.65 ns | 108.73 ns |     704 B |
|     Sort_LastItemAsPivot_OrderedArray | 6,513.3 ns | 128.98 ns | 158.40 ns |     424 B |
|    Sort_PivotInTheMiddle_OrderedArray |   737.8 ns |  14.67 ns |  16.30 ns |     424 B |

## Selection Sort

|           Method |     Mean |    Error |   StdDev | Allocated |
|----------------- |---------:|---------:|---------:|----------:|
|        SortArray | 17.74 us | 0.106 us | 0.082 us |     704 B |
| GenericSortArray | 42.58 us | 0.857 us | 1.334 us |  119504 B |

## Insertion Sort

|      Method |       Mean |     Error |    StdDev | Allocated |
|------------ |-----------:|----------:|----------:|----------:|
|        Sort | 6,208.6 ns | 123.49 ns | 177.11 ns |     704 B |
| SortOrdered |   222.7 ns |   4.46 ns |   9.31 ns |     424 B |

## Bubble Sort

|      Method |        Mean |    Error |   StdDev | Allocated |
|------------ |------------:|---------:|---------:|----------:|
|        Sort | 23,550.0 ns | 79.66 ns | 70.62 ns |     704 B |
| SortOrdered |    180.4 ns |  2.35 ns |  2.20 ns |     424 B |