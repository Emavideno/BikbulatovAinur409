using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_21_11_2024
{
    internal class UnqueSymbols
    {
        public static string LongestSubArrayWithUniqueSymbols()
        {
            // Тут 2 решения - понятное, но долгое и быстрое(я надеюсь), но труднчитабельное
            Console.Write("Введите строку: "); 
            string line = Console.ReadLine();
            string subString;
            int passageCondition;
            string maxLengthString = "";
            for (int i = 0; i < line.Length; i++)
            {
                //for (int j = i; j < line.Length; j++)
                //{
                //    passageCondition = 0;
                //    subString = line.Substring(i, line.Length - j);

                //    for (int k = 0; k < subString.Length; k++)
                //    {
                //        for (int l = k + 1; l < subString.Length; l++)
                //        {
                //            if (subString[l] == subString[k])
                //            {
                //                passageCondition++;
                //            }
                //        }
                //    }

                //    if (passageCondition == 0 & maxLengthString.Length < subString.Length)
                //        maxLengthString = subString;
                //}
                for (int j = i; j < line.Length; j++)
                {
                    passageCondition = 0;
                    subString = line.Substring(i, line.Length - j);

                    foreach (char charI in subString)
                    {
                        if (subString.IndexOf(charI) != subString.LastIndexOf(charI))
                        {
                            passageCondition++;
                            break;
                        }
                    }

                    if (maxLengthString.Length < subString.Length & passageCondition == 0)
                        maxLengthString = subString;
                }
            }
            return maxLengthString;
        }
    }
}
