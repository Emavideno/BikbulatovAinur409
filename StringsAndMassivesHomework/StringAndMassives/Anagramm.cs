using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndMassives
{
    internal class Anagramm
    {
        public static bool IsStringAnagramm()
        {
            Console.Write("Введите первую строку: ");
            string firstString = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string secondString = Console.ReadLine();

            if (secondString.Length == firstString.Length)
                foreach (char charI in secondString)
                {
                    int index = firstString.IndexOf(charI);
                    if (index >= 0)
                    {
                        firstString = firstString.Remove(index, 1);
                    }
                    else
                    {
                        return false;
                    }
                }

            if (firstString == "")
                return true;
            return false;
        }
    }
}
