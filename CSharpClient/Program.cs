using System.Text;
using TemperatureLibrary;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        /*
         * Завдання 2

        Створіть власну користувальницьку збірку за прикладом складання CarLibrary з уроку, 
        складання буде використовуватися для роботи з конвертером температури.
        */


        TemperatureConverter converter = new TemperatureConverter();

        Console.WriteLine("25°C переведемо в Фаренгейт: " + converter.CelsiusToFahrenheit(25));
        Console.WriteLine("77°F переведемо в Цельсій: " + converter.FahrenheitToCelsius(77));
        Console.WriteLine("100°C переведемо в Келвіни: " + converter.CelsiusToKelvin(100));
        Console.WriteLine("300K переведемо в Цельсій: " + converter.KelvinToCelsius(300));
    }
}
