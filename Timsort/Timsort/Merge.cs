using System;

namespace Timsort
{
    internal class Merge
    {
        public static void MergeSortedArrays(int[] arr, int l, int m, int r, int[] temp)
        {
            int len1 = m - l + 1;

            Array.Copy(arr, l, temp, 0, len1);

            int i = 0, j = m + 1, k = l;

            while (i < len1 && j <= r)
            {
                if (temp[i] <= arr[j])
                    arr[k++] = temp[i++];
                else
                    arr[k++] = arr[j++];
            }

            while (i < len1)
                arr[k++] = temp[i++];
        }
    }
}