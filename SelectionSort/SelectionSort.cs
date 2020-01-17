namespace SelectionSort
{
    public static class SelectionSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int idx_smallest = i; 

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[idx_smallest])
                    {
                        idx_smallest = j;
                    }

                    var temp = array[i];
                    array[i] = array[idx_smallest];
                    array[idx_smallest] = temp;
                }
            }
        }
    }
}
