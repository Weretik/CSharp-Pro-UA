namespace _3._Input_and_Output_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Завдання 6

            Створіть на диску 100 директорій із іменами від Folder_0 до Folder_99, потім видаліть їх.
            */

            string path = @"C:\Folder";
            DirectoryInfo directory = new DirectoryInfo(path);

            if (!directory.Exists)
            {
                directory.Create();
            }
            for (int i = 0; i < 100; i++)
            {
                directory.CreateSubdirectory($"Folder_{i}");
            }
            //Видалення директорій
            directory.Delete(true);

        }
    }
}
