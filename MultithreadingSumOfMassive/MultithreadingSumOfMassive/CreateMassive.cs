using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingSumOfMassive
{
    internal class CreateMassive
    {
        public static int[] GenerateMassive(int sizeOfMassive)
        {
            int[] arr = new int[sizeOfMassive];

            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next();
            }

            return arr;
        }
    }
}
