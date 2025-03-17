using System.Reflection;
using System.Text;

namespace _7._Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * Завдання 2

            Створіть клас і застосуйте до його методів атрибут Obsolete спочатку у формі, що просто виводить попередження, 
            а потім у формі, що перешкоджає компіляції. Продемонструйте роботу атрибута з прикладу виклику даних методів.
            */

            MyClass myClass = new MyClass();
            myClass.OldMethod();
            myClass.NewMethod();
            //myClass.DeprecatedMethod();
            Console.WriteLine();

            /*
             * Завдання 5

            Створіть атрибут користувача AccessLevelAttribute, який дозволяє визначити рівень доступу користувача до системи. 
            Сформуйте склад співробітників певної фірми як набору класів, наприклад, Manager, Programmer, Director. За допомогою 
            атрибута AccessLevelAttribute розподіліть рівні доступу персоналу та відобразіть на екрані реакцію системи на спробу
            кожного співробітника отримати доступ до захищеної секції.
            */

            Manager manager = new Manager();
            Programer programer = new Programer();
            Director director = new Director();

            SecureSystem.CheckAccessLevel(manager);
            Console.WriteLine();
            SecureSystem.CheckAccessLevel(programer);
            Console.WriteLine();
            SecureSystem.CheckAccessLevel(director);

            Console.WriteLine();






            /*
             * Завдання 3 

            Розширте можливості програми-рефлектора з попереднього уроку таким чином:
            1. Додайте можливість вибирати, які саме члени типу мають бути показані користувачеві. При цьому має бути можливість вибирати відразу кілька членів типу, наприклад, методи та властивості.
            2. Додайте можливість виводу інформації про атрибути для типів та всіх членів типу, які можуть бути декоровані атрибутами.
            */




            Assembly asm = Assembly.LoadFrom(@"C:\Users\User\OneDrive\Рабочий стол\C#\C# Pro UA\TemperatureLibrary\bin\Debug\net8.0\TemperatureLibrary.dll");
            Console.WriteLine($"\nЗавантажено збірку: {asm.FullName}\n");


            Type[] types = asm.GetTypes();
            Console.WriteLine("Оберіть, які члени типів показати (через кому):");
            Console.WriteLine("1 - Методи\n2 - Властивості\n3 - Поля\n4 - Події\n5 - Атрибути");
            string[] choices = Console.ReadLine().Split(',');

            bool showMethods = choices.Contains("1");
            bool showProperties = choices.Contains("2");
            bool showFields = choices.Contains("3");
            bool showEvents = choices.Contains("4");
            bool showAttributes = choices.Contains("5");

            foreach (Type type in types)
            {
                Console.WriteLine($"Тип: {type.FullName}");

                if (showAttributes)
                {
                    PrintAttributes(type);
                }

                if (showMethods)
                {
                    MethodInfo[] methods = type.GetMethods();
                    foreach (MethodInfo method in methods)
                    {
                        Console.WriteLine($"Метод: {method.ReturnType} {method.Name}({string.Join(", ", method.GetParameters().Select(p => p.ToString()))})");
                        if (showAttributes) PrintAttributes(method);
                    }
                }

                if (showProperties)
                {
                    PropertyInfo[] properties = type.GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        Console.WriteLine($"Властивість: {property.PropertyType} {property.Name}");
                        if (showAttributes) PrintAttributes(property);
                    }
                }

                if (showFields)
                {
                    FieldInfo[] fields = type.GetFields();
                    foreach (FieldInfo field in fields)
                    {
                        Console.WriteLine($"Поле: {field.FieldType} {field.Name}");
                        if (showAttributes) PrintAttributes(field);
                    }
                }

                if (showEvents)
                {
                    EventInfo[] events = type.GetEvents();
                    foreach (EventInfo ev in events)
                    {
                        Console.WriteLine($"Подія: {ev.EventHandlerType} {ev.Name}");
                        if (showAttributes) PrintAttributes(ev);
                    }
                }

                Console.WriteLine(new string('-', 50));



            }
        }
        static void PrintAttributes(MemberInfo member)
        {
            object[] attributes = member.GetCustomAttributes(false);
            if (attributes.Length > 0)
            {
                Console.WriteLine("  Атрибути:");
                foreach (var attr in attributes)
                {
                    Console.WriteLine($"    - {attr.GetType().Name}");
                }
            }
        }
    }
}