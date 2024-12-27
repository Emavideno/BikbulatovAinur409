using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CorporateSettlement;

namespace Corporate_Settlement
{
    public class Friend
    {
        public string Name { get; set; }
        public decimal AmountSpent { get; set; }
        public decimal OrderAmount { get; set; }

        public Friend(string name, decimal amountSpent, decimal orderAmount)
        {
            Name = name;
            AmountSpent = amountSpent;
            OrderAmount = orderAmount;
        }
    }

    internal class Friends
    {
        public static List<Friend> friends = new List<Friend>();

        public static void HowToImportFriends() 
        {
            while (true)
            {
                Console.WriteLine("Выберите опцию:");
                Console.WriteLine("1. Ввести данные о друзьях вручную");
                Console.WriteLine("2. Импортировать данные из CSV-файла");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    FriendsListInput();
                    break;
                }
                else if (choice == "2")
                {
                    string filePath = @"C:\Users\Fantast\source\repos\Corporate_Settlement\friends_data.csv";
                    ImportFriendsFromCsv(filePath);
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный выбор.");
                }

                BeatifulOutput();
            }
        }
        public static void FriendsListInput()  // Вводим имена друзей.
        {
            Console.WriteLine("Введите данные о друзьях (введите '0' для завершения): ");
            string friendName;

            while (true)
            {
                Console.Write("Имя друга: ");
                friendName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(friendName))
                {
                    Console.WriteLine("Имя не может быть пустым или состоять только из пробелов. Пожалуйста, введите другое имя.");
                    continue;
                }

                if (friendName.ToLower() == "0")
                    break;

                if (friends.Exists(f => f.Name.Equals(friendName, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Друг с таким именем уже существует. Пожалуйста, введите другое имя.");
                    continue;
                }

                friends.Add(new Friend(friendName, 0, 0));
            }

            BeatifulOutput();
        }

        public static void ImportFriendsFromCsv(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool isFirstLine = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            continue;
                        }

                        string[] values = line.Split("  ");

                        if (values.Length > 0)
                        {
                            string name = values[0];

                            if (!friends.Exists(f => f.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                            {
                                friends.Add(new Friend(name, 0, 0));
                            }
                        }
                    }
                }
                Console.WriteLine("Друзья успешно импортированы из файла.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при импорте данных: {ex.Message}");
            }
        }

        public static bool TryAddFriend(string newFriendName)  // Пробуем добавить друга в список.
        {
            if (string.IsNullOrWhiteSpace(newFriendName))
            {
                Console.WriteLine("Имя не может быть пустым или состоять только из пробелов. Пожалуйста, введите другое имя.");
                return false;
            }

            if (friends.Exists(f => f.Name.Equals(newFriendName, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Друг с таким именем уже существует. Пожалуйста, введите другое имя.");
                return false;
            }

            friends.Add(new Friend(newFriendName, 0, 0));
            return true;
        }

        public static decimal AddFriendGetOrder()  // Метод добавления друзей и потраченной суммы в контексте бара
        {
            decimal summ = 0;
            while (true)
            {
                Console.Write("Хотите добавить ещё одного друга? (введите 'Да' для продолжения, 'Нет' для завершения): ");
                string addFriendResponse = Console.ReadLine();

                if (addFriendResponse.Equals("Нет", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (addFriendResponse.Equals("Да", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Имя нового друга: ");
                    string newFriendName = Console.ReadLine();

                    if (TryAddFriend(newFriendName))
                    {
                        decimal orderAmount;

                        while (true)
                        {
                            Console.Write($"Имя: {newFriendName}, Потрачено: ");
                            string input = Console.ReadLine();
                            input = input.Replace(".", ",");
                            if (decimal.TryParse(input, out orderAmount) && orderAmount >= 0)
                            {
                                friends[^1].OrderAmount += orderAmount;
                                summ += orderAmount;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Пожалуйста, введите корректную сумму (нельзя отрицательное значение).");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неправильный ввод, попробуйте ещё раз.");
                }
            }
            return summ;
        }
    }
}
