using System.Xml.Linq;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json; 

/*Завдання 6 

Створіть .xml файл, який би відповідав наступним вимогам:

• ім'я файлу: TelephoneBook.xml

• кореневий елемент: “MyContacts”

• тег “Contact”, і в ньому має бути записано ім'я контакту та атрибут “TelephoneNumber” зі значенням номера телефону
*/



XDocument telephoneBook1 = new XDocument(new XElement("MyContacts",
    new XElement("Contact",
        new XAttribute("TelephoneNumber", "+(380) 96 087 77 08"),
        "Ivan"),
    new XElement("Contact",
        new XAttribute("TelephoneNumber", "+(380) 96 087 77 09"),
        "Victor")));

telephoneBook1.Save(@"C:\Users\User\OneDrive\Рабочий стол\C#\C# Pro UA\5. XML. Configuration files. Registry\TelephoneBook.xml");



/*
 * Завдання 2

Створіть програму, яка виводить на екран всю інформацію про вказаний .xml файл.
*/


XDocument telephoneBook = XDocument.Load(@"C:\Users\User\OneDrive\Рабочий стол\C#\C# Pro UA\5. XML. Configuration files. Registry\TelephoneBook.xml");

XElement root = telephoneBook.Element("MyContacts");

Console.WriteLine(root);


/*
Завдання 3

З файлу TelephoneBook.xml (файл повинен був бути створений у процесі виконання додаткового завдання) виведіть на екран лише номери телефонів.
*/
Console.WriteLine();
if (root != null)
{
    foreach (XElement contact in root.Elements("Contact"))
    {
        XAttribute telephoneNumber = contact.Attribute("TelephoneNumber");
        if (telephoneNumber != null)
        {
            Console.WriteLine($"Telephone number: {telephoneNumber.Value}");
            Console.WriteLine();
        }
    }
}

/*Завдання 4 

Використовуючи приклади, розглянуті на уроці, створіть свою програму для адміністратора, 
яка зберігатиме дані конфігурації у спеціальному файлі або в реєстрі. Створіть програму користувача, 
зовнішнім виглядом якого можна керувати за допомогою адмінпрограми.
 * 
 */

var configuration = new ConfigurationBuilder()
    .AddJsonFile(@"C:\Users\User\OneDrive\Рабочий стол\C#\C# Pro UA\5. XML. Configuration files. Registry\settings.json")
    .Build();

var consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), configuration["Application:ConsoleColor"]);
Console.ForegroundColor = consoleColor;


var envConfig = configuration.GetSection("Environment").Get<EnvironmentConfig>();

Console.WriteLine($"Database Name: {envConfig.Database.Name}");
Console.WriteLine($"Connection String: {envConfig.Database.ConnectionString}");

Console.WriteLine(new string('-', 30));

Console.WriteLine("Hello world!");

Console.ReadLine();


public class EnvironmentConfig
{
    public DatabaseConfig Database { get; set; }
}

public class DatabaseConfig
{
    public string Name { get; set; }
    public string ConnectionString { get; set; }
}