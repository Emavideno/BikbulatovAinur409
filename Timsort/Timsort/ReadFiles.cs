using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timsort
{
    internal class ReadFiles
    {
        public static int[] Read(string? path, out int amountOfLines)
        {
            amountOfLines = 0;
            var numbers = new List<int>();

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    numbers.Add(int.Parse(line));
                    amountOfLines++;
                }
            }

            return numbers.ToArray();
        }
    }
}
