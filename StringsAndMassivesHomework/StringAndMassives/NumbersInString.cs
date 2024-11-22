using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndMassives
{
    public static class NumbersFromString
    {
        public static string GetNumbersFromString()
        {
            Console.Write("Введите сторку: ");
            string stringNumbers = Console.ReadLine();
            string numbersFromString = "";
            string numbers = "0123456789";
            foreach (char s in stringNumbers)
            {
                foreach (char c in numbers)
                {
                    if (c == s)
                    {
                        numbersFromString += s;
                    }
                }
            }
            return numbersFromString;
        }
    }
}
