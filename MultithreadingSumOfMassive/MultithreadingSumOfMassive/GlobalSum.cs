using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingSumOfMassive
{
    public class GlobalSum
    {
        private readonly int[] _array;
        private readonly int _size;
        private readonly int _threadCount;

        public GlobalSum(int[] array, int Size, int threadCount)
        {
            _array = array;
            _size = Size;
            _threadCount = threadCount;
        }

        public ulong CalculateGlobalSum()
        {
            Thread[] threads = new Thread[_threadCount];
            Parametrs[] threadData = new Parametrs[_threadCount];

            for (int i = 0; i < _threadCount; i++)
            {
                threadData[i] = new Parametrs
                {
                    StartNum = i,
                    Array = _array,
                    Size = _size
                };

                threads[i] = new Thread(LocalSum.CalculateLocalSum);
                threads[i].Start(threadData[i]);
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            ulong totalSum = 0;
            foreach (var data in threadData)
            {
                totalSum += data.LocalSum;
            }

            return totalSum;
        }
    }
}
