using System.Text;

namespace _13._TPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * Завдання 2

            Створіть два методи, які виконуватимуться у межах паралельних завдань. Організуйте виклик цих методів за допомогою Invoke таким чином, 
            щоб основний потік програми (метод Main) не зупинив виконання.
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
            Console.WriteLine();

            /*
             * Завдання 4

            Створіть масив чисел розмірністю 1000000 або більше. Використовуючи генератор випадкових чисел, проініціалізуйте цей масив значеннями. 
            Створіть PLINQ запит, який дозволить отримати усі непарні числа з вихідного масиву.
            */
            Random random = new Random();

            int[] numbers = new int[1000000];
            
            Parallel.For(0, numbers.Length, (i) =>
            {
                numbers[i] = random.Next(0, 100);
            });

            var results = numbers
                .AsParallel()
                .Where(n => n % 2 != 0)
                .ToArray();


        }
        //* Завдання 2
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
