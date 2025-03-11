using System.Text;

namespace _2._System_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * Завдання 2

            Створіть колекцію, до якої можна додавати покупців та категорію придбаної ними продукції. 
            З колекції можна отримувати категорії товарів, які купив покупець або за категорією визначити покупців.
            */

            var customerPurchases = new Dictionary<string, string>()
            {
                { "Віталій", "Телефони" },
                { "Юра", "Блендер" },
                { "Антон", "Телефони" }

            };


            Console.WriteLine("Віталій купив: " + customerPurchases["Віталій"]);
            Console.WriteLine("Юра купив: " + customerPurchases["Юра"]);
            Console.WriteLine("Антон купив: " + customerPurchases["Антон"]);

            Console.WriteLine();
            Console.WriteLine("Клієнти які купили Телефони:");
            foreach (var (key, value) in customerPurchases)
            {
                if (value == "Телефони")
                {
                    Console.WriteLine(key);
                }
            }


            /*
             * Завдання 3

                Декількома способами створіть колекцію, в якій можна зберігати тільки цілі та речові значення, на кшталт «рахунок підприємства – доступна сума» відповідно.
 
             */

            // Перший спосіб

            Dictionary<int, double> accounts = new Dictionary<int, double>();

            accounts.Add(101, 15000.50);
            accounts.Add(102, 25000.75);
            accounts.Add(103, 12500.20);

            foreach (var account in accounts)
            {
                Console.WriteLine($"Рахунок {account.Key} - доступна сума: {account.Value} грн.");
            }


            // Другий спосіб
            List<Account> accounts2 = new List<Account>();

            // Додаємо рахунки
            accounts2.Add(new Account(101, 15000.50));
            accounts2.Add(new Account(102, 25000.75));
            accounts2.Add(new Account(103, 12500.20));

            // Виводимо інформацію по рахунках
            foreach (var account in accounts2)
            {
                Console.WriteLine($"Рахунок {account.AccountNumber} - доступна сума: {account.AvailableAmount} грн.");
            }


        }

    }
    public class Account
    {
        public int AccountNumber { get; set; }
        public double AvailableAmount { get; set; }

        public Account(int accountNumber, double availableAmount)
        {
            AccountNumber = accountNumber;
            AvailableAmount = availableAmount;
        }
    }
}
