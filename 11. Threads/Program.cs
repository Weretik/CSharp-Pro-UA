using System.Text;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _11._Threads_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * Завдання 2

            Створіть консольну програму, яка в різних потоках зможе отримати доступ до 2-х файлів. 
            Вважайте з цих файлів вміст і спробуйте записати отриману інформацію в третій файл. 
            Читання/запис мають здійснюватися одночасно у кожному з дочірніх потоків. 
            Використовуйте блокування потоків для того, щоб досягти коректного запису в кінцевий файл.
            */

            File.WriteAllText(outputFile, "");

            Thread thread1 = new Thread(() => ReadAndWrite(file1));
            Thread thread2 = new Thread(() => ReadAndWrite(file2));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Файли об'єднані в output.txt");
            Console.WriteLine();
            
            /*
             * Завдання 4

               Використовуючи конструкції блокування, модифікуйте останній приклад уроку таким чином, щоб отримати можливість послідовної роботи 3-х потоків.
            */

            Thread[] threads = { new Thread(Function), new Thread(Function), new Thread(Function) };

            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

        }
        // * Завдання 2
        private static object lockObject = new object();
        private static string file1 = "file1.txt";
        private static string file2 = "file2.txt";
        private static string outputFile = "output.txt";

        static void ReadAndWrite(string inputFile)
        {
            string content;

            using (StreamReader reader = new StreamReader(inputFile))
            {
                content = reader.ReadToEnd();
            }

            lock (lockObject)
            {
                using (StreamWriter writer = new StreamWriter(outputFile, true))
                {
                    writer.WriteLine(content);
                }
            }
        }

        // * Завдання 4
        static int counter = 0;
        static object block = new object();
        static void Function()
        {
            for (int i = 0; i < 50; ++i)
            {
                lock (block)
                {
                    Console.WriteLine(++counter);
                }
            }
        }
    }
}
