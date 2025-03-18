using System;



class Program
{
    static void Main()
    {
        /*
         * 
         * Завдання 2

        Створіть клас, який дозволить виконувати моніторинг ресурсів, що використовуються програмою. Використовуйте його з метою спостереження за роботою програми, а саме:
        користувач може вказати прийнятні рівні споживання ресурсів (пам'яті), а методи класу дозволять видати попередження, коли кількість ресурсів, що реально використовуються,
        наблизитися до максимально допустимого рівня.
        */
        
        long maxMemory = 50 * 1024 * 1024;
        var resourceMonitor = new ResourceMonitor(maxMemory);

        resourceMonitor.MonitorMemoryUsage();
    }
}
public class ResourceMonitor
{
    private readonly long _maxMemoryUsage;
    private long _currentMemoryUsage;

    public ResourceMonitor(long maxMemoryUsage)
    {
        _maxMemoryUsage = maxMemoryUsage;
    }

    // Метод для моніторингу пам'яті
    public void MonitorMemoryUsage()
    {
        _currentMemoryUsage = GC.GetTotalMemory(false);

        if (_currentMemoryUsage >= _maxMemoryUsage)
        {
            Console.WriteLine($"Попередження! Використання пам'яті: {_currentMemoryUsage} байт перевищує максимально допустимий рівень.");
        }
        else
        {
            Console.WriteLine($"Поточне використання пам'яті: {_currentMemoryUsage} байт.");
        }
    }
}