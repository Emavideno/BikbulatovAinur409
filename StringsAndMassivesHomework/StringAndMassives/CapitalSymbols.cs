using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndMassives
{
    public static class CapitalSymbols
    {
        public static string DoFirstSymbolsCapital()
        {
            string check1 = "hello world dkjfo ojdca";
            var strings = check1.Split();
            string camelCasedString = "";
            foreach (string strI in strings)
            {
                camelCasedString += Char.ToUpper(strI[0]) + strI.TrimStart(new char[] { strI[0] }) + " ";
            }
            return camelCasedString;
        }
    }
}
