using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporate_Settlement
{
    internal class Calculator
    {
        public class Debt
        {
            public string Creditor { get; set; } // Кто должен
            public string Debtor { get; set; } // Кому должны
            public decimal Amount { get; set; } // Сумма долга

            public Debt(string creditor, string debtor, decimal amount)
            {
                Creditor = creditor;
                Debtor = debtor;
                Amount = amount;
            }
        }

        public static List<Debt> debts = new List<Debt>();

        public static void Calculate()
        {
            foreach (var friend in Friends.friends)
            {
                if (friend.AmountSpent > 0)
                {
                    decimal amountSpent = friend.AmountSpent;
                    friend.AmountSpent -= friend.OrderAmount;
                    friend.OrderAmount -= amountSpent;
                    //Console.WriteLine($"Имя: {friend.Name}, Потрачено: {friend.AmountSpent:0.00}, Заказано на сумму: {friend.OrderAmount}");
                }
            }

            // Расчет долгов
            for (int i = 0; i < Friends.friends.Count; i++)
            {
                if (Friends.friends[i].OrderAmount > 0)
                {
                    for (int j = 0; j < Friends.friends.Count; j++)
                    {
                        if (i != j && Friends.friends[j].AmountSpent > 0)
                        {
                            decimal transferAmount = Math.Min(Friends.friends[i].OrderAmount, Friends.friends[j].AmountSpent);

                            debts.Add(new Debt(Friends.friends[i].Name, Friends.friends[j].Name, transferAmount));

                            Friends.friends[i].OrderAmount -= transferAmount; // Уменьшаем счётчик "долга".
                            Friends.friends[j].AmountSpent -= transferAmount; // Уменьшаем счётчик сколько должны.

                            Console.WriteLine($"{Friends.friends[i].Name} => {Friends.friends[j].Name} : {transferAmount:0.00}");
                        }
                    }
                }
            }
        }
    }
}
