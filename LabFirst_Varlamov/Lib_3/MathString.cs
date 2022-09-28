using System;
using System.Windows;

namespace Lib_3
{
    public static class MathString
    {
        /// <summary>
        /// ����� ������������ ������
        /// </summary>
        /// <param name="count">���������� ����� � �������</param>
        /// <param name="min">����������� ����� � �������</param>
        /// <param name="max">������������ ����� � �������</param>
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
        /// ����� ���������� ����� � �������� �������
        /// </summary>
        /// <param name="numbers">������</param>
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
