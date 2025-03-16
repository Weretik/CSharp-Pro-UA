using System.Reflection;
using System.Text;

namespace Reflector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            /*
             * Завдання 5

            Створіть програму-рефлектор, яка дозволить отримати інформацію про складання та типи, що входять до її складу. 
            Для основи можна використовувати програму-рефлектор із уроку.
            */

            Assembly asm = Assembly.LoadFrom(@"C:\Users\User\OneDrive\Рабочий стол\C#\C# Pro UA\TemperatureLibrary\bin\Debug\net8.0\TemperatureLibrary.dll");
            Console.WriteLine($"\nЗавантажено збірку: {asm.FullName}\n");

            Type[] types = asm.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine($"Тип: {type.FullName}");

                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine($"Метод: {method.ReturnType} {method.Name}({string.Join(", ", method.GetParameters().Select(p => p.ToString()))})");
                }

                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine($"Властивість: {property.PropertyType} {property.Name}");
                }

                Console.WriteLine(new string('-', 50));
            }
        }
    }
}