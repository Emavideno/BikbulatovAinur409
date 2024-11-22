using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDigitSum
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите значение N (1 ≤ N ≤ 27): ");
            int N = int.Parse(Console.ReadLine());

            if (N < 1 || N > 27)
            {
                Console.WriteLine("Ошибка: N должно быть в диапазоне от 1 до 27.");
                return;
            }

            int count = CountThreeDigitNumbers(N);
            Console.WriteLine($"Количество трехзначных чисел, сумма цифр которых равна {N}: {count}");
        }

        static int CountThreeDigitNumbers(int N)
        {
            int count = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        if (a + b + c == N)
                            count++;
                    }
                }
            }
            return count;
        }
    }
}
