namespace QuickSort
{
    public class QuickSort
    {
        public static void Sort(int[] array, int min, int max)
        {
            if (array.Length < 2)
                return;

            if (min < max)
            {
                int partitionIdx = Partition(array, min, max);

                Sort(array, min, partitionIdx - 1);
                Sort(array, partitionIdx + 1, max);
            }
        }

        private static int Partition(int[] array, int min, int max)
        {
            // set pivot
            int pivot = array[max];

            int lowIdx = min - 1;

            // Reorder
            for (int i = min; i < max; i++)
            {
                if (array[i] <= pivot)
                {
                    lowIdx++;

                    int temp = array[lowIdx];
                    array[lowIdx] = array[i];
                    array[i] = temp;
                }
            }

            int temp2 = array[lowIdx + 1];
            array[lowIdx + 1] = array[max];
            array[max] = temp2;

            return lowIdx + 1;
        }

        public static void Sort2(int[] array, int min, int max)
        {
            int minIdx = min;
            int maxIdx = max;

            int pivot = array[(min + max) / 2];

            do
            {
                while ((array[minIdx] < pivot) && (minIdx < max))
                    minIdx++;

                while ((pivot < array[maxIdx]) && (maxIdx > min))
                    maxIdx--;

                if (minIdx <= maxIdx)
                {
                    int temp = array[minIdx];
                    array[minIdx] = array[maxIdx];
                    array[maxIdx] = temp;
                    minIdx++;
                    maxIdx--;
                }
            }
            while (minIdx <= maxIdx);

            if (min < maxIdx)
                Sort2(array, min, maxIdx);

            if (minIdx < max)
                Sort2(array, minIdx, max);
        }
    }
}
