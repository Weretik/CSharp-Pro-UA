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


            /*Завдання 3 

            Створіть колекцію, яка б за своєю структурою нагадувала «родове дерево» (ім'я людини, рік народження), 
            причому до неї можна додавати/вилучати нового родича, є можливість побачити всіх спадкоємців обраної людини, 
            відібрати родичів за роком народження. 
            */
            Console.WriteLine();
            var grandparent = new FamilyMember("Дідусь", 1940);
            var parent = new FamilyMember("Тато", 1970);
            var child = new FamilyMember("Син", 2000);
            var child2 = new FamilyMember("Дочка", 2005);

            var familyTree = new FamilyTree(grandparent);

            familyTree.AddFamilyMember(parent, grandparent);
            familyTree.AddFamilyMember(child, parent);
            familyTree.AddFamilyMember(child2, parent);

            
            Console.WriteLine("Нащадки тата:");
            foreach (var descendant in familyTree.GetDescendants(parent))
            {
                Console.WriteLine($"- {descendant.Name}, {descendant.BirthYear}");
            }

            Console.WriteLine();
            Console.WriteLine("Діти, народжені в 2000 році:");
            foreach (var person in familyTree.GetChildrenByBirthYear(parent, 2000))
            {
                Console.WriteLine($"- {person.Name}, {person.BirthYear}");
            }
        }
        
    }
}
