using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassivesHomework
{
    internal class NumInMassiveClass
    {
        public static void NumInMassive(int[] array, int number)
        {
            int tempIEnd = array.Length - 1;
            int tempIStart = 0;
            int tempIMid = array.Length / 2;

            while (tempIStart <= tempIEnd)
            {
                tempIMid = (tempIEnd + tempIStart) / 2;
                Console.WriteLine();
                if (array[tempIMid] == number)
                {
                    Console.WriteLine($"Ваше число под индексом: {tempIMid}");
                    return;
                }
                else if (number > array[tempIMid])
                    tempIStart = tempIMid + 1;
                else
                    tempIEnd = tempIMid - 1;
            }

            Console.WriteLine("Вашего числа нет(");
        }
    }
}
