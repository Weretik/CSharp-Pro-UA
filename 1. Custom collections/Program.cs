using System.Text;
namespace _1._Custom_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * Завдання 2

            Створіть колекцію, в якій зберігалися б найменування 12 місяців, порядковий номер і кількість днів у відповідному місяці. 
            Реалізуйте можливість вибору місяців як за порядковим номером, так і кількістю днів у місяці, при цьому результатом може бути не тільки один місяць.
            */

            MonthCollection months = new MonthCollection();

            foreach (var month in months)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine();
            Console.WriteLine("Пошук місяців за номером 5:");
            Month monthByNumber = months.FindByNumber(5);
            Console.WriteLine(monthByNumber.Name);

            Console.WriteLine();
            Console.WriteLine("Пошук місяця за кілкістю днів 30:");
            Month[] monthByDays = months.FindByDays(30);
            foreach (var month in monthByDays)
            {
                Console.WriteLine(month.Name);
            }
        }
        
    }
}
