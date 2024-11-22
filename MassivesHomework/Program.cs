using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassivesHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeatifulOutput();
            Console.WriteLine("Ответ на третью задачу");
            Cube.RandomCube();

            BeatifulOutput();
            int[] array = InputArray();

            BeatifulOutput();
            Console.WriteLine("           Массив отсортирован");
            int[] sortedArray = BubbleSortClass.BubbleSort(array);

            BeatifulOutput();
            Console.Write("Введите число, индекс которого вы хотите найти в массиве: ");
            int number = int.Parse(Console.ReadLine());
            NumInMassiveClass.NumInMassive(sortedArray, number);
            BeatifulOutput();
        }
        public static void BeatifulOutput()
        {
            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine();
        }
        public static int[] InputArray()
        {
            Console.WriteLine("             Определяем массив...");
            Console.Write("Введите сколько элементов вы хотите в массиве: ");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите целое число: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
    }
}
