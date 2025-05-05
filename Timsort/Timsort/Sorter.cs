using System;
using System.Collections.Generic;

namespace Timsort
{
    internal class Sorter
    {
        private const int MIN_MERGE = 32;
        private static int[]? _tempArray;

        public static void Sort(int[] arr, int run, out int iterations)
        {
            iterations = 0;
            int n = arr.Length;
            if (n < 2) return;

            _tempArray = new int[n / 2];
            var runs = new Stack<(int start, int len)>();

            // Вычисляем минимальный размер run
            int minRun = GetMinRun(n);
            int current = 0;

            while (current < n)
            {
                // Находим натуральный run
                int runEnd = FindNaturalRun(arr, current, n - 1);
                int runLength = runEnd - current;

                // Если run слишком маленький, расширяем его
                if (runLength < minRun)
                {
                    runLength = Math.Min(minRun, n - current);
                    iterations += InsertionSort.DoInsertionSort(arr, current, current + runLength - 1, 0);
                }

                runs.Push((current, runLength));
                current += runLength;

                // Проверяем условия для слияния
                while (runs.Count >= 3)
                {
                    var (start1, len1) = runs.Pop();
                    var (start2, len2) = runs.Pop();
                    var (start3, len3) = runs.Pop();

                    if (len2 <= len1 + len3 || len3 <= len1)
                    {
                        if (len1 <= len3)
                        {
                            Merge.MergeSortedArrays(arr, start2, start2 + len2 - 1, start2 + len2 + len1 - 1, _tempArray);
                            iterations++;
                        }
                        else
                        {
                            Merge.MergeSortedArrays(arr, start3, start3 + len3 - 1, start3 + len3 + len2 - 1, _tempArray);
                            iterations++;
                        }
                    }
                    else
                    {
                        runs.Push((start3, len3));
                        runs.Push((start2, len2));
                        runs.Push((start1, len1));
                        break;
                    }
                }
            }

            // Финальное слияние оставшихся runs
            while (runs.Count > 1)
            {
                var (start1, len1) = runs.Pop();
                var (start2, len2) = runs.Pop();
                Merge.MergeSortedArrays(arr, start2, start2 + len2 - 1, start2 + len2 + len1 - 1, _tempArray);
                iterations++;
                runs.Push((start2, len2 + len1));
            }
        }

        private static int GetMinRun(int n)
        {
            int r = 0;
            while (n >= MIN_MERGE)
            {
                r |= n & 1;
                n >>= 1;
            }
            return n + r;
        }

        private static int FindNaturalRun(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
                return startIndex;

            int i = startIndex + 1;
            if (arr[i - 1] <= arr[i])
            {
                while (i <= endIndex && arr[i - 1] <= arr[i])
                    i++;
            }
            else
            {
                while (i <= endIndex && arr[i - 1] > arr[i])
                    i++;
                Array.Reverse(arr, startIndex, i - startIndex);
            }

            return i;
        }
    }
}