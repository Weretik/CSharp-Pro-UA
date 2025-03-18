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
        }
    }
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
}
