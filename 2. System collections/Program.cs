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
        }
    }
}
