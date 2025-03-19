namespace _12._Synchronization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Завдання 3

            Створіть програму, яка може бути запущена лише в одному екземплярі (використовуючи іменований Mutex).
            */
            bool isMutexAcquired = false;
            Mutex mutex = new Mutex(true, "UniqueMutex", out isMutexAcquired);

            if (!isMutexAcquired)
            {
                Console.WriteLine("Програма вже запущена!");
                return;
            }

            Console.WriteLine("Програма успішно запущена!");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Цикл: {i + 1}: *");
                Thread.Sleep(500);
            }

            Console.WriteLine("Програма завершена. Натисніть будь-яку клавішу для виходу...");

            mutex.ReleaseMutex();
        }
    }
}
