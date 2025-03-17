using System.Xml.Serialization;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.Json;

namespace _8._Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * Завдання 2

            Створіть клас, який підтримує серіалізацію. Виконайте серіалізацію цього об'єкта у форматі XML.
            Спочатку використовуйте формат за промовчанням, а потім змініть його таким чином,
            щоб значення полів збереглися як атрибути елементів XML.
            */
            Person person = new Person("Віктор", 25, new Company("Microsoft"));

            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            using(FileStream fs = new FileStream("person.xml", FileMode.Create))
            {
                serializer.Serialize(fs, person);
            }


            /*
             * 
             * Завдання 3

            Створіть нову програму, в якій виконайте десеріалізацію об'єкта з попереднього прикладу. Відобразіть стан об'єкта на екрані.
            */

            Person deserializerPerson;
            XmlSerializer deserializer = new XmlSerializer(typeof(Person));

            using (FileStream fs = new FileStream("person.xml", FileMode.Open))
            {
                deserializerPerson = (Person)serializer.Deserialize(fs);
            }
            Console.WriteLine("Об'єкт десеріалізовано:");
            Console.WriteLine($"Ім'я: {deserializerPerson.Name}, Вік: {deserializerPerson.Age}, Назва компанії: {deserializerPerson.Company.Name}");
            Console.WriteLine();

            /*
             * Завдання 5 

            Створіть тип користувача (наприклад, клас) і виконайте серіалізацію об'єкта цього типу, враховуючи той факт, що стан об'єкта необхідно буде передати по мережі.
            */
            
            User user = new User("Іван", 30, "ivan@example.com");

            byte[] serializedUser;
            using (MemoryStream ms = new MemoryStream())
            {
                JsonSerializer.Serialize(ms, user);
                serializedUser = ms.ToArray();
            }

            Console.WriteLine("Об'єкт серіалізовано в байти.");

            User deserializedUser;
            using (MemoryStream ms = new MemoryStream(serializedUser))
            {
                deserializedUser = JsonSerializer.Deserialize<User>(ms);
            }

            Console.WriteLine("Об'єкт десеріалізовано із байтів:");
            Console.WriteLine($"Ім'я: {deserializedUser.Name}, Вік: {deserializedUser.Age}, Назва компанії: {deserializedUser.Email}");

        }
    }
    public class Person(string name, int age, Company company)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;

        public Company Company { get; set; } = company;

        public Person() : this("Underfined", 0, new Company("Underfined"))
        {
       
        }


    }
    public class Company(string name)
    {
        [XmlAttribute]
        public string Name { get; set; } = name;

        public Company() : this("Underfined")
        {
        }
    }

    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public User(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public User() { }
    }
}
