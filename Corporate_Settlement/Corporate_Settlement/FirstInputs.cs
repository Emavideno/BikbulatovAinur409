using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporate_Settlement
{
    internal class FirstInputs
    {
        public static string corpOutputName = "";
        public static string corpOutputPath = "";
        public static string corpName = "";
        public static string corpDate = "";

        public static void PrimordialInput()
        {
            while (true) // Проверка названия корпоратива
            {
                Console.Write("Введите название корпоратива: ");
                corpName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(corpName))
                {
                    Console.WriteLine("Имя не может быть пустым");
                    continue;
                }
                break;
            }

            while (true) // Проверка даты
            {
                Console.Write("Введите дату корпоратива: ");
                corpDate = Console.ReadLine();
                if (!DateTime.TryParse(corpDate, out DateTime date))
                {
                    Console.WriteLine("Ошибка: Пожалуйста, введите корректную дату.");
                    continue;
                }
                break;
            }

            while (true) // Проверка пути (Можно было сделать, чтобы он проверял можно ли создать там файл, но мне лень)
            {
                Console.Write("Введите путь куда сохранить вывод: ");
                corpOutputPath = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(corpOutputPath))
                {
                    Console.WriteLine("Ошибка: Путь для сохранения не может быть пустым.");
                    continue;
                }
                break;
            }

            while (true) // Проверка имени выходного файла (Вторую часть взял у гпт)
            {
                Console.Write("Введите имя выходного файла: ");
                corpOutputName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(corpOutputName) || corpOutputName.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) >= 0)
                {
                    Console.WriteLine("Ошибка: Имя выходного файла не может быть пустым и не должно содержать недопустимые символы.");
                    continue;
                }
                break;
            }

            string fullPath = Path.Combine(corpOutputPath, corpOutputName);
            FileOutput.SaveToFile(fullPath);
        }
    }
}
