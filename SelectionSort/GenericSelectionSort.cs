using System;

namespace SelectionSort
{
    // http://www.rosettacode.org/wiki/Sorting_algorithms/Selection_sort#C.23
    class GenericSelectionSort<T> where T : IComparable
    {
        public static T[] Sort(T[] list)
        {
            int k;
            T temp;

            for (int i = 0; i < list.Length; i++)
            {
                k = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j].CompareTo(list[k]) < 0)
                    {
                        k = j;
                    }
                }
                temp = list[i];
                list[i] = list[k];
                list[k] = temp;
            }

            return list;
        }
    }
}
