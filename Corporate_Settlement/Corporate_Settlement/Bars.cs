using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporate_Settlement
{
    internal class Bars
    {
        public class BarInfo
        {
            public string BarName { get; set; }
            public string WhoClosed { get; set; }
            public List<FriendExpense> Expenses { get; set; } // Список расходов друзей
            public decimal TotalSpent { get; set; }

            public BarInfo(string barName, string whoClosed)
            {
                BarName = barName;
                WhoClosed = whoClosed;
                Expenses = new List<FriendExpense>();
            }
        }

        public class FriendExpense
        {
            public string FriendName { get; set; }
            public decimal AmountSpent { get; set; }

            public FriendExpense(string friendName, decimal amountSpent)
            {
                FriendName = friendName;
                AmountSpent = amountSpent;
            }
        }

        public static List<BarInfo> barInfos = new List<BarInfo>(); // Список для хранения информации о барах

        public static void BarInfoInput()
        {
            Console.Write("Введите наименование заведения: ");
            string barName = Console.ReadLine();
            string whoClosed = "";
            bool flag = true;
            while (flag)
            {
                Console.Write("Введите имя того, кто закрыл счёт: ");
                whoClosed = Console.ReadLine();

                if (Friends.friends.Exists(f => f.Name.Equals(whoClosed, StringComparison.OrdinalIgnoreCase)))
                {
                    break;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Такого человека в списке нет. Желаете добавить? (введите 'Да' для продолжения, 'Нет' для завершения): ");
                        string addFriendResponse = Console.ReadLine();
                        if (addFriendResponse.Equals("Нет", StringComparison.OrdinalIgnoreCase))
                        {
                            break;
                        }
                        else if (addFriendResponse.Equals("Да", StringComparison.OrdinalIgnoreCase))
                        {
                            Friends.TryAddFriend(whoClosed);
                            flag = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Неправильный ввод. Введите ещё раз");
                        }
                    }
                }
            }

            Console.WriteLine("Введите потраченную сумму каждого человека в этом баре: ");
            decimal orderAmount;
            decimal localSumm = 0;

            BarInfo barInfo = new BarInfo(barName, whoClosed);
            
            // Ввод сумм для друзей
            foreach (var friend in Friends.friends)
            {
                while (true)
                {
                    Console.Write($"Имя: {friend.Name}, Потрачено: ");
                    string input = Console.ReadLine();
                    input = input.Replace(".", ",");
                    if (decimal.TryParse(input, out orderAmount) && orderAmount >= 0)
                    {
                        localSumm += (decimal)orderAmount;
                        friend.OrderAmount += orderAmount;
                        barInfo.Expenses.Add(new FriendExpense(friend.Name, orderAmount)); // Добавление расхода друга
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, введите корректную сумму (нельзя отрицательное значение).");
                    }
                }
            }

            localSumm += (decimal)Friends.AddFriendGetOrder();
            barInfo.TotalSpent = localSumm;
            Friend friendWhoClosed = Friends.friends.Find(f => f.Name.Equals(whoClosed, StringComparison.OrdinalIgnoreCase));
            if (friendWhoClosed != null)
            {
                friendWhoClosed.AmountSpent += localSumm;
            }

            barInfos.Add(barInfo);
            CorporateSettlement.BeatifulOutput();
            Console.WriteLine($"Сумма, потраченная {whoClosed}: {localSumm}");
        }

        public static void AddBar()
        {
            while (true)
            {
                Console.Write("Хотите добавить бар? (введите 'Да' для продолжения, 'Нет' для завершения): ");
                string addFriendResponse = Console.ReadLine();

                if (addFriendResponse.Equals("Нет", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (addFriendResponse.Equals("Да", StringComparison.OrdinalIgnoreCase))
                {
                    BarInfoInput();
                }
                else
                {
                    Console.WriteLine("Неправильный ввод. Введите ещё раз");
                }
            }
        }
    }
}
