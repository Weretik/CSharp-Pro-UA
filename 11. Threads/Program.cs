using System.Text;
using System.Threading;

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
        }
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
    }
}
