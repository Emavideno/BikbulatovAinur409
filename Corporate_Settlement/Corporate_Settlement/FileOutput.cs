using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CorporateSettlement;

namespace Corporate_Settlement
{
    internal class FileOutput
    {
        public static void SaveFriendsToCsv()
        {

            string filePath = @"friends_data.csv";
            string absolutePath = Path.GetFullPath(filePath);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Если файл новый, записываем заголовки
                if (new FileInfo(filePath).Length == 0)
                {
                    writer.WriteLine("Name  AmountSpent  OrderAmount");
                }

                foreach (var friend in Friends.friends)
                {
                    string line = string.Join("  ", friend.Name, friend.AmountSpent, friend.OrderAmount);
                    writer.WriteLine(line);
                }
            }
            Console.WriteLine($"Информация о друзьях сохранена в {absolutePath}");
        }

        public static void SaveToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine($"===={FirstInputs.corpName}====");
                    writer.WriteLine($"{FirstInputs.corpDate}\n");
                    foreach (var barInfo in Bars.barInfos)
                    {
                        writer.WriteLine($"===={barInfo.BarName}====");
                        writer.WriteLine($"Общий счёт: {barInfo.TotalSpent}");
                        writer.WriteLine($"Кто закрыл: {barInfo.WhoClosed}");

                        int i = 0;
                        foreach (var expense in barInfo.Expenses)
                        {
                            i++;
                            writer.WriteLine($"{i}. {expense.FriendName} {expense.AmountSpent}");
                        }
                        writer.WriteLine("===============\n");
                    }
                    writer.WriteLine("====Расчёт====");
                    for (int i = 0; i < Calculator.debts.Count; i++)
                    {
                        Calculator.Debt? debt = Calculator.debts[i];
                        writer.WriteLine($"{debt.Creditor} => {debt.Amount} => {debt.Debtor}");
                    }
                }
                Console.WriteLine("Данные успешно сохранены в файл.");
            }
            catch (Exception ex)
            {
                while (true)
                {
                    Console.WriteLine($"Произошла ошибка при сохранении в файл: {ex.Message}");
                    Console.WriteLine("============ТРЕВОГА============");
                }
            }
        }
    }
}
