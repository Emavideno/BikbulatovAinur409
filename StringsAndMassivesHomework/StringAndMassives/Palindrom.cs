using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndMassives
{
    internal class Palindrom
    {
        public static bool IsStringPalindrom()
        {
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();
            line = line.ToUpperInvariant();
            var passageCondition = 0;
            for (int i = 0; i < line.Length / 2; i++)
            {
                if (line[i] == line[line.Length - 1 - i])
                {
                    passageCondition++;
                }
            }
            if (passageCondition == line.Length / 2)
            {
                return true;
            }
            return false;
        }
    }
}
