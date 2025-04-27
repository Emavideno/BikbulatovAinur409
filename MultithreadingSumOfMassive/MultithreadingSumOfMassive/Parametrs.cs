using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingSumOfMassive
{
    internal class Parametrs
    {
        public int StartNum { get; set; }
        public int[] Array { get; set; }
        public int Size { get; set; }
        public ulong LocalSum { get; set; }
    }
}
