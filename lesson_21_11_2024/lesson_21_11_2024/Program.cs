using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_21_11_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumbersFromString.GetNumbersFromString());
            BeatifulOutput();
            Console.WriteLine(CapitalSymbols.DoFirstSymbolsCapital());
            BeatifulOutput();
            Console.WriteLine(Palindrom.IsStringPalindrom());
            BeatifulOutput();
            Console.WriteLine(Anagramm.IsStringAnagramm());
            BeatifulOutput();
            Console.WriteLine(UnqueSymbols.LongestSubArrayWithUniqueSymbols());
        }

        public static void BeatifulOutput()
        {
            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine();
        }
        //public static void fafaf()
        //{
        //    //Длина строки
        //    string text = "Hello, World!";
        //    Console.WriteLine(text.Length); // Вывод: 13

        //    //Извлечение подстроки
        //    string sub = text.Substring(7, 5); // Извлекает "World"
        //    Console.WriteLine(sub);

        //    //Разделение строки
        //    string str = "Apple,Banana,Cherry";
        //    string[] fruits = text.Split(',');
        //    Console.WriteLine(string.Join(" ", fruits)); // Вывод: Apple Banana Cherry

        //    //Объединение строк
        //    string result = string.Join(", ", fruits);
        //    Console.WriteLine(result); // Вывод: Apple, Banana, Cherry

        //    //Изменение регистра
        //    Console.WriteLine(text.ToUpper()); // Вывод: HELLO, WORLD!
        //    Console.WriteLine(text.ToLower()); // Вывод: hello, world!

        //    //Удаление пробелов
        //    string dirtyText = "   Hello, World!   ";
        //    Console.WriteLine(text.Trim()); // Вывод: "Hello, World!"
        //    Console.WriteLine(text.TrimStart()); // Вывод: "Hello, World!   "
        //    Console.WriteLine(text.TrimEnd()); // Вывод: "   Hello, World!"

        //    //Поиск в строке
        //    Console.WriteLine(text.IndexOf('o')); // Вывод: 4
        //    Console.WriteLine(text.LastIndexOf('o')); // Вывод: 8

        //    //Проверка наличия подстроки
        //    Console.WriteLine(text.Contains("World")); // Вывод: True

        //    //Замена символов или подстроки
        //    string replaced = text.Replace("World", "C#");
        //    Console.WriteLine(replaced); // Вывод: Hello, C#!

        //    Console.WriteLine(text.StartsWith('H')); // true
        //    Console.WriteLine(text.EndsWith("World!"));  // True

        //    //Проверка пустой строки
        //    string empty = " ";
        //    Console.WriteLine(string.IsNullOrEmpty(empty)); // False
        //    Console.WriteLine(string.IsNullOrWhiteSpace(empty)); // True

        //    //Удаление части строки
        //    string resultAfterRemoved = text.Remove(5, 7); // Удаляет ", World"
        //    Console.WriteLine(result); // Вывод: Hello!
        //}
    }
}
