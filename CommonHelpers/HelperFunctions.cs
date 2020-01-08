using System;

namespace CommonHelpers
{
    public static class HelperFunctions
    {
        public static int[] GenerateIntegers(int amount)
        {
            Random rnd = new Random();
            int[] intArr = new int[amount];
            int max = amount * 10;

            for (int i = 0; i < intArr.Length; i++)
            {
                int num = rnd.Next(1, max);
                intArr[i] = num;
            }

            return intArr;
        }

        public static int[] GenerateIntegersOrdered(int amount)
        {
            int[] intArr = new int[amount];

            for (int i = 0; i < intArr.Length; i++)
            {
                int num = i+1;
                intArr[i] = num;
            }

            return intArr;
        }
    }
}
