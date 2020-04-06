using System;

namespace BubbleSort
{
    public static class BubbleSort
    {
        public static void Sort(int[] array)
        {
            var doItAgain = false;
            var limit = array.Length;
            var defaultNextValue = Int32.MaxValue;

            for (int i = 0; i < limit; i++)
            {
                var thisValue = array[i];
                var nextValue = i + 1 < limit ? array[i + 1] : defaultNextValue;

                if (nextValue < thisValue)
                {
                    array[i] = nextValue;
                    array[i + 1] = thisValue;
                    doItAgain = true;
                }
            }
            if (doItAgain)
            {
                Sort(array);
            }
        }
    }
}
