using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingSumOfMassive
{
    internal class StraightCount
    {
        public static ulong CountStraight(int[] array)
        {
            ulong summ = 0;
            foreach (var number in array)
            {
                summ += (ulong)number;
            }

            return summ;
        }
    }
}
