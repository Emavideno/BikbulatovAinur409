using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNumberBinary
{
    internal class DoBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число: ");
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("Число меньше нуля");
                return;
            }
            string result = "";

            while (N > 0)
            {
                result += N % 2;
                N /= 2;
            }

            Console.WriteLine(result.Reverse().ToArray());
        }
    }
}
