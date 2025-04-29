using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimsortTest
{
    internal class TestIter
    {
        public static int DoSomething(int iterations)
        {
            for (int i = 0; i < 10; i++)
            {
                iterations++;
            }
            return iterations;
        }
    }
}
