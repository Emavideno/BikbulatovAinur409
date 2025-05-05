using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timsort
{
    internal class ArrayOutput
    {
        public static void PrintArray(int[] arr)
        {
            int i = 0;
            foreach (int num in arr)
            {
                if (i < 9)    // Чтобы в несколько столбцов выводились числа
                {
                    Console.Write(num + " ");
                    i++;
                }
                else
                {
                    i = 0;
                    Console.WriteLine();
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=============================================================================================================");
            Console.WriteLine();
        }
    }
}
