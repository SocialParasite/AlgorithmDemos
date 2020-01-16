namespace InsertionSort
{
    public class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int currentValue = array[i];
                int pointer = i - 1;

                while (pointer >= 0 && array[pointer] > currentValue)
                {
                    array[pointer + 1] = array[pointer];
                    pointer -= 1;
                }

                array[pointer + 1] = currentValue;
            }

            return array;
        }
    }
}
