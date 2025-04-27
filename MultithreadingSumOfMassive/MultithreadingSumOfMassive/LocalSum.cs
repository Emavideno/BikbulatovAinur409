using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingSumOfMassive
{
    internal class LocalSum
    {
        public static void CalculateLocalSum(object obj)
        {
            Parametrs data = (Parametrs)obj;
            ulong sum = 0;
            int startIndex = data.StartNum * data.Size;
            int endIndex = Math.Min(startIndex + data.Size, data.Array.Length);

            for (int i = startIndex; i < endIndex; i++)
            {
                sum += (ulong)data.Array[i];
            }

            data.LocalSum = sum;
        }
    }
}
