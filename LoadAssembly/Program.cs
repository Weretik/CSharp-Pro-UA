using System.Text;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;


        /*
         * Завдання 3

        Створіть програму, в якій надайте користувачеві доступ до збірки із завдання 2. 
        Реалізуйте використання методу конвертації значення температури зі шкали Цельсія в шкалу Фаренгейта. Виконуючи завдання використовуйте лише рефлексію.
        */

        Assembly assembly = Assembly.LoadFrom(@"C:\Users\User\OneDrive\Рабочий стол\C#\C# Pro UA\TemperatureLibrary\bin\Debug\net8.0\TemperatureLibrary.dll");

        Type type = assembly.GetType("TemperatureLibrary.TemperatureConverter");

        object instanceTemperatureConverter = Activator.CreateInstance(type);

        MethodInfo method = type.GetMethod("CelsiusToFahrenheit");

        Console.Write("Введіть температуру в градусах Цельсія: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double celsius))
        {
            object result = method.Invoke(instanceTemperatureConverter, new object[] { celsius });

            Console.WriteLine($"Результат: {celsius}°C = {result}°F");
        }
        else
        {
            Console.WriteLine("Некоректне введення! Введіть число.");
        }
    }
}
