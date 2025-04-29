using System.Diagnostics;
using System.IO;
using OfficeOpenXml;
using Timsort;

int run = 32;
var watch = new Stopwatch();
int amountOfLines = 0;

// Все массивы были отсортированы правильно, проверял равенство отсортированных массивов этим методом и с помощью встроенной сортировки

for (int numberOfMassive = 0; numberOfMassive < 100; numberOfMassive++)
{
    var path = @"C:\Users\Fantast\source\repos\FilesWithNumbers\NumFile" + numberOfMassive + ".txt";    // Измените путь на свой (начало)
    int[] array = ReadFiles.Read(path, out amountOfLines); 
    watch.Start();
    Sorter.Sort(array, run, out int iterations);
    watch.Stop();

    var time = watch.Elapsed;
    Console.WriteLine($"Файл {numberOfMassive} содержащий {amountOfLines} строк: выполнился за {time.TotalMilliseconds} мс, {iterations} итераций");
    watch.Reset();

    //ArrayOutput.PrintArray(array);    // Если захотите вывести массив, можете воспользоваться
}


//// Если желаете сохранить в Excel (измените путь в самом низу и в середине)

//ExcelPackage.License.SetNonCommercialPersonal("Fantast");
//using (var package = new ExcelPackage())
//{
//    var worksheet = package.Workbook.Worksheets.Add("Sorting Results");

//    // Заголовки столбцов
//    worksheet.Cells["A1"].Value = "Номер файла";
//    worksheet.Cells["B1"].Value = "Количество строк";
//    worksheet.Cells["C1"].Value = "Время выполнения (мс)";
//    worksheet.Cells["D1"].Value = "Количество итераций";

//    // "Холостой" запуск, без него у первого файла ненормальное время
//    int[] warmup = ReadFiles.Read(0, out amountOfLines);
//    Sorter.Sort(warmup, run, out _);

//    int row = 2; // Начинаем со второй строки (первая - заголовки)

//    for (int numberOfMassive = 0; numberOfMassive < 100; numberOfMassive++)
//    {
//        var path = @"C:\Users\Fantast\source\repos\FilesWithNumbers\NumFile" + numberOfMassive + ".txt";    // Измените путь на свой (начало)
//        int[] array = ReadFiles.Read(path, out amountOfLines);
//        watch.Start();
//        Sorter.Sort(array, run, out int iterations);
//        watch.Stop();

//        var time = watch.Elapsed;
//        Console.WriteLine($"Файл {numberOfMassive} содержащий {amountOfLines} строк: выполнился за {time.TotalMilliseconds} мс, {iterations} итераций");

//        // Записываем данные в Excel
//        worksheet.Cells[row, 1].Value = numberOfMassive;
//        worksheet.Cells[row, 2].Value = amountOfLines;
//        worksheet.Cells[row, 3].Value = time.TotalMilliseconds;
//        worksheet.Cells[row, 4].Value = iterations;

//        row++;
//        watch.Reset();
//    }

//    string filePath = @"C:\Users\Fantast\source\repos\FilesWithNumbers\SortingResults.xlsx";
//    package.SaveAs(new FileInfo(filePath));
//    Console.WriteLine($"Результаты сохранены в {filePath}");
//}