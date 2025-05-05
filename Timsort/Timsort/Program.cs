using System.Diagnostics;
using System.IO;
using OfficeOpenXml;
using Timsort;

int run = 32;
var watch = new Stopwatch();
int amountOfLines = 0;


for (int numberOfMassive = 0; numberOfMassive < 100; numberOfMassive++)
{
    var path = @"C:\Users\Fantast\source\repos\FilesWithNumbers\NumFile" + numberOfMassive + ".txt";    // Измените путь на свой
    int[] array = ReadFiles.Read(path, out amountOfLines); 
    watch.Start();
    Sorter.Sort(array, run, out int iterations);
    watch.Stop();

    var time = watch.Elapsed;
    Console.WriteLine($"Файл {numberOfMassive} содержащий {amountOfLines} строк: выполнился за {time.TotalMilliseconds} мс, {iterations} итераций");
    watch.Reset();

    //ArrayOutput.PrintArray(array);    // Если захотите вывести массив, можете воспользоваться
}
