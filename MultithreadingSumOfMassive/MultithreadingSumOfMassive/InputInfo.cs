using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingSumOfMassive
{
    internal class InputInfo
    {
        public static (int size, int amount) Input()
        {
            Console.Write("Введите размер желаемого массива: ");
            int.TryParse(Console.ReadLine(), out int sizeOfMassive);

            Console.Write("Введите количество желаемых потоков(такое, чтобы размер нацело поделился на кол-во): ");
            int.TryParse(Console.ReadLine(), out int amountOfThreads);

            return (sizeOfMassive, amountOfThreads);
        }
    }
}
