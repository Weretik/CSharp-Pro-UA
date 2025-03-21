namespace _13._TPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Завдання 2

            Створіть два методи, які виконуватимуться у межах паралельних завдань. Організуйте виклик цих методів за допомогою Invoke таким чином, щоб основний потік програми (метод Main) не зупинив виконання.
            */
            Parallel.Invoke(
                () => PrintGreetings(),
                () => Square(5)
            );

            Console.WriteLine($"Поточний потік: {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(" * ");
            }
            Console.WriteLine("Основнйи потік закінчив роботу");
        }
        static void PrintGreetings()
        {
            Console.WriteLine($"Поточний потік: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(200);
            Console.WriteLine("Hello, World!");
        }
        static void Square(int x)
        {
            Console.WriteLine($"Поточний потік: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(200);
            Console.WriteLine(x * x);
        }

    }
}
