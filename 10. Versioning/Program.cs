namespace _10._Versioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Завдання 2

            Вивчіть опис шаблону Template method (Шаблонний метод). Зверніть увагу на застосування шаблону, а також на склад його учасників і зв'язку відносини між ними. 
            Напишіть невелику програму мовою C#, що є абстрактною реалізацією даного шаблону.
            */

            Console.WriteLine("Обробка текстового документа:");
            DocumentProcessor textProcessor = new TextDocumentProcessor();
            textProcessor.ProcessDocument();

            Console.WriteLine("\nОбробка XML-документа:");
            DocumentProcessor xmlProcessor = new XmlDocumentProcessor();
            xmlProcessor.ProcessDocument();
            /*
             * Завдання 4

            Реалізуйте шаблон NVI у власній ієрархії успадкування.


            */
            Console.WriteLine("Збереження у текстовий файл:");
            FileSaver textSaver = new TextFileSaver();
            textSaver.SaveFile();

            Console.WriteLine("Збереження у JSON-файл:");
            FileSaver jsonSaver = new JsonFileSaver();
            jsonSaver.SaveFile();

        }
    }
    // * Завдання 2
    abstract class DocumentProcessor
    {
        public void ProcessDocument()
        {
            OpenDocument();
            ParseDocument();
            SaveDocument();
            CloseDocument();
        }

        protected void OpenDocument()
        {
            Console.WriteLine("Документ відкрито.");
        }

        protected void CloseDocument()
        {
            Console.WriteLine("Документ закрито.");
        }

        protected abstract void ParseDocument();
        protected abstract void SaveDocument();
    }

    class TextDocumentProcessor : DocumentProcessor
    {
        protected override void ParseDocument()
        {
            Console.WriteLine("Аналіз текстового документа...");
        }

        protected override void SaveDocument()
        {
            Console.WriteLine("Збереження документа у текстовому форматі.");
        }
    }

    class XmlDocumentProcessor : DocumentProcessor
    {
        protected override void ParseDocument()
        {
            Console.WriteLine("Аналіз XML-документа...");
        }

        protected override void SaveDocument()
        {
            Console.WriteLine("Збереження документа у форматі XML.");
        }
    }


    // * Завдання 4
    abstract class FileSaver
    {
        public void SaveFile()
        {
            Console.WriteLine("Ініціалізація процесу збереження файлу...");
            OpenFile();
            WriteContent();
            CloseFile();
            Console.WriteLine("Файл успішно збережено!\n");
        }

        private void OpenFile()
        {
            Console.WriteLine("Відкриття файлу для запису...");
        }

        private void CloseFile()
        {
            Console.WriteLine("Закриття файлу...");
        }

        protected abstract void WriteContent();
    }

    class TextFileSaver : FileSaver
    {
        protected override void WriteContent()
        {
            Console.WriteLine("Запис текстового вмісту у файл...");
        }
    }

    class JsonFileSaver : FileSaver
    {
        protected override void WriteContent()
        {
            Console.WriteLine("Запис вмісту у форматі JSON...");
        }
    }
}
