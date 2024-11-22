using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassivesHomework
{
    internal class Cube
    {
        public static void RandomCube()
        {
            int[,,] cube = new int[6, 3, 3]
            {
                {
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 }
                },
                {
                    { 0, 0, 0 },
                    { 1, 0, 1 },
                    { 0, 0, 0 }
                },
                {
                    { 0, 0, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 0 }
                },
                {
                    { 1, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 1 }
                },
                {
                    { 1, 0, 1 },
                    { 0, 1, 0 },
                    { 1, 0, 1 }
                },
                {
                    { 1, 0, 1 },
                    { 1, 0, 1 },
                    { 1, 0, 1 }
                }
            };

            Random random = new Random();
            int faceIndex = random.Next(6);

            Console.WriteLine($"Результат броска (Грань {faceIndex + 1})");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(cube[faceIndex, i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
