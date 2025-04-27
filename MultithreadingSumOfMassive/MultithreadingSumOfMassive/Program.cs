using MultithreadingSumOfMassive;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

(int sizeOfMassive, int amountOfThreads) = InputInfo.Input();
int[] array = CreateMassive.GenerateMassive(sizeOfMassive);

var sw = new Stopwatch();
sw.Start();
var calculator = new GlobalSum(array, sizeOfMassive / amountOfThreads, amountOfThreads);
ulong multiThreadingSum = calculator.CalculateGlobalSum();
sw.Stop();
var threadingSumTime = sw.Elapsed;
Console.WriteLine($"Я разделился на {amountOfThreads} частей и насчитал: {multiThreadingSum} за {threadingSumTime}");

sw = Stopwatch.StartNew();
ulong straightSum = StraightCount.CountStraight(array);
sw.Stop();
var straightSumTime = sw.Elapsed;
Console.WriteLine($"Я никуда не делился и посчитал: {straightSum} за {straightSumTime}");

Console.WriteLine();
Console.WriteLine($"Совпало ли значение - {multiThreadingSum == straightSum}");
Console.WriteLine($"С помощью многопоточности код быстрее в {straightSumTime / threadingSumTime} или же на {straightSumTime - threadingSumTime}");