using System.Globalization;
using System.Threading.Tasks;
using System.Text;
using System.Diagnostics;
using System.IO.Compression;

namespace _3._Input_and_Output_Programming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*Завдання 6

            Створіть на диску 100 директорій із іменами від Folder_0 до Folder_99, потім видаліть їх.
            */
            /*
            string path = @"C:\Folder";
            DirectoryInfo directory = new DirectoryInfo(path);

            if (!directory.Exists)
            {
                directory.Create();
            }
            for (int i = 0; i < 100; i++)
            {
                directory.CreateSubdirectory($"Folder_{i}");
            }
            //Видалення директорій
            directory.Delete(true);
            
            */


            /*
             * Завдання 2
                Створіть файл, запишіть у нього довільні дані та закрийте файл. Потім знову відкрийте цей файл, прочитайте дані і виведіть їх на консоль.
             * 
             */
            string pathFile = @"C:\Users\User\OneDrive\Рабочий стол\C#\Text.txt";
            FileInfo file = new FileInfo(pathFile);


            if (!file.Exists)
            {
                using (StreamWriter writer = new StreamWriter(pathFile))
                {
                    writer.WriteLine("Мета компанії проста: це забезпечення вам інновацій, відкриттів та новаторства.");
                    writer.WriteLine("Хочемо вражати стильних особистостей якістю глобального громадянства і прагнемо розвивати кабельне телебачення,");
                    writer.WriteLine("пасажирські перевезення і ремонт ювелірних виробів і годинників разом із іноземними компаніями.");
                }

            }
            else
            {
                using (StreamReader reader = new StreamReader(pathFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                file.Delete();
            }
            Console.WriteLine();
            /*
             * Завдання 3

            Напишіть програму для пошуку заданого файлу на диску.
            Додайте код, який використовує клас FileStream і дозволяє переглядати файл у текстовому вікні. Насамкінець додайте можливість стиснення знайденого файлу.
            */
            Console.WriteLine("Search:");
            string[] findFile = Directory.GetFiles(@"C:\Users\User\OneDrive\Рабочий стол\C#", "Text.txt", SearchOption.AllDirectories);

            foreach (var item in findFile)
            {
                Console.WriteLine($"Знайдено файл:\n{item}");

                Console.Write("Прочитати та стиснути файл: y/n");
                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (answer == 'y')
                {
                    string compressedFilePath = @"C:\Users\User\OneDrive\Рабочий стол\C#\Text.gz";

                    using (FileStream originalFileStream = new FileStream(item, FileMode.Open, FileAccess.Read))
                    using (FileStream compressedFileStream = new FileStream(compressedFilePath, FileMode.Create))
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        byte[] bytes = new byte[originalFileStream.Length];
                        originalFileStream.Read(bytes, 0, (int)originalFileStream.Length);

                        string content = Encoding.UTF8.GetString(bytes);
                        Console.WriteLine(content);

                        originalFileStream.CopyTo(compressionStream);
                    }

                    Console.WriteLine("Файл стиснуто");
                }

            }
        }
    }
}
