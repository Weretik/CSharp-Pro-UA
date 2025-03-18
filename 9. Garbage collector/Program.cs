using System.Text;

namespace _9._Garbage_collector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /*
             * 
             * Завдання 2

            Створіть клас, який дозволить виконувати моніторинг ресурсів, що використовуються програмою. Використовуйте його з метою спостереження за роботою програми, а саме:
            користувач може вказати прийнятні рівні споживання ресурсів (пам'яті), а методи класу дозволять видати попередження, коли кількість ресурсів, що реально використовуються,
            наблизитися до максимально допустимого рівня.
            */

            long maxMemory = 50 * 1024 * 1024;
            var resourceMonitor = new ResourceMonitor(maxMemory);

            resourceMonitor.MonitorMemoryUsage();

            /*
             * Завдання 4

            Створіть свій клас, об'єкти якого займатимуть багато місця в пам'яті (наприклад, у коді класу буде великий масив) і реалізуйте для цього класу формалізований шаблон очищення.
            */
            var largeObject = new LargeObject(10_000_000);

            largeObject.Dispose();

            GC.Collect();
            Console.WriteLine("Збірка сміття виконана.");

        }
    }
    public class ResourceMonitor
    {
        private readonly long _maxMemoryUsage;
        private long _currentMemoryUsage;

        public ResourceMonitor(long maxMemoryUsage)
        {
            _maxMemoryUsage = maxMemoryUsage;
        }

        public void MonitorMemoryUsage()
        {
            _currentMemoryUsage = GC.GetTotalMemory(false);

            if (_currentMemoryUsage >= _maxMemoryUsage)
            {
                Console.WriteLine($"Попередження! Використання пам'яті: {_currentMemoryUsage} байт перевищує максимально допустимий рівень.");
            }
            else
            {
                Console.WriteLine($"Поточне використання пам'яті: {_currentMemoryUsage} байт.");
            }
        }
    }
    public class LargeObject : IDisposable
    {
        private int[] largeArray;
        private bool disposed = false;

        public LargeObject(int size)
        {
            largeArray = new int[size];
            Console.WriteLine($"Об'єкт створено з масивом розміром {size} елементів.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    largeArray = null;
                    Console.WriteLine("Ресурси очищено.");
                }

                disposed = true;
            }
        }

        ~LargeObject()
        {
            Dispose(false);
        }
    }
}
