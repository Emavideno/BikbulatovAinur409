using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timsort
{
    internal class InsertionSort
    {
        public static int DoInsertionSort(int[] arr, int left, int right, int iterations)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= left && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;

                    iterations++;
                }
                arr[j + 1] = temp;
            }

            return iterations;
        }
    }
}
