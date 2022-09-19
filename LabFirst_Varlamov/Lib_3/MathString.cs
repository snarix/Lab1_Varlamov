using System;

namespace Lib_3
{
    public static class MathString
    {
        public static int ArrayCreate(int[] numbers)
        {
            Random rnd = new();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-4, 7);
            }
            return numbers.Length;
        }

        public static double SignSquare(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    Math.Sqrt(numbers[i]);
                }
                if (numbers[i] < 0)
                {
                    Math.Pow(numbers[i], 2);
                }
            }
            return numbers.Length;
        }




    }
}
