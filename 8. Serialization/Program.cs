using System.Xml.Serialization;

namespace _8._Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Завдання 2

            Створіть клас, який підтримує серіалізацію. Виконайте серіалізацію цього об'єкта у форматі XML.
            Спочатку використовуйте формат за промовчанням, а потім змініть його таким чином,
            щоб значення полів збереглися як атрибути елементів XML.
            */
            Person person = new Person("Віктор", 25, new Company("Microsoft"));

            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            using(FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, person);
            }



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
}
