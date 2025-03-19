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
            /*
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
            */




            /*
             * Завдання 5

            Створіть Semaphore, що контролює доступу до ресурсу з кількох потоків. Організуйте впорядкований висновок інформації про отримання доступу до спеціального файлу *.log.
            */

            if (!File.Exists(logFilePath))
            {
                using (File.Create(logFilePath)) { }
                Console.WriteLine("Файл журнала створений.");
            }

            Thread[] threads = new Thread[10];
            for (int i = 0; i < threads.Length; i++)
            {
                int threadId = i + 1;
                threads[i] = new Thread(() => AccessResource(threadId));
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("Всі потоки завершили свою роботу.");

        }
        static Semaphore semaphore = new Semaphore(3, 5); 
        static string logFilePath = "access_log.log";

        static void AccessResource(int threadId)
        {
            Console.WriteLine($"Потік {threadId} чекає на доступ...");
            semaphore.WaitOne();

            try
            {
                Console.WriteLine($"Потік {threadId} отримав доступ до файлу.");
                WriteToLogFile(threadId);
                Thread.Sleep(1000);
            }
            finally
            {
                Console.WriteLine($"Потік {threadId} звільнив доступ до файлу.");
                semaphore.Release();
            }
        }

        static void WriteToLogFile(int threadId)
        {
            string logMessage = $"Потік {threadId} отримав доступ до файлу на {DateTime.Now}\n";

            using (FileStream fs = new FileStream(logFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(logMessage);
            }
        }
    }
}
