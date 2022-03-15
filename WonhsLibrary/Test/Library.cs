using System;
using System.Collections.Generic;
using System.Text;

namespace WonhsLibrary.Test
{
    public class Library
    {
        /// <summary>
        /// 선택 정렬 알고리즘
        /// </summary>
        /// <param name="resultNumbers">정수배열</param>
        /// <returns>오름차순 정렬된 정수형 배열</returns>
        public static int[] SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }
    }
}
