using System;
using System.Windows;

namespace Lib_3
{
    public static class MathString
    {
        public static int[] ArrayCreate(int count, int min = -4, int max = 7)
        {
                int[] numbers = new int[count];
                Random rnd = new();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(min, max);
                }
                return numbers;
        }


        public static int[] SignSquare(this int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    numbers[i] = (int)Math.Sqrt(numbers[i]);
                    
                }
                if (numbers[i] < 0)
                {
                    numbers[i] = (int)Math.Pow(numbers[i], 2);
                }
            }
            return numbers;
        }
    }
}
