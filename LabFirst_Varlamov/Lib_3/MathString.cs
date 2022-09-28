using System;
using System.Windows;

namespace Lib_3
{
    public static class MathString
    {
        /// <summary>
        /// Метод генерирующий массив
        /// </summary>
        /// <param name="count">Количество ячеек в массиве</param>
        /// <param name="min">Минимальное число в массиве</param>
        /// <param name="max">Максимальное число в массиве</param>
        /// <returns></returns>

        public static double[] ArrayCreate(int count, int min = -4, int max = 7)
        {
                double[] numbers = new double[count];
                Random rnd = new();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(min, max);
                }
                return numbers;
        }

        /// <summary>
        /// Метод вычисления корня и квадрата массива
        /// </summary>
        /// <param name="numbers">Массив</param>
        /// <returns></returns>
        /// 
        public static double[] SignSquare(this double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    numbers[i] = (double)Math.Sqrt(numbers[i]);
                    numbers[i] = Math.Round(numbers[i], 2);
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
