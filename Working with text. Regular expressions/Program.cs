
using System;
using System.Globalization;
using System.Text.RegularExpressions;

/*
 * Завдання 2

Напишіть програму, яка дозволила б за вказаною адресою web-сторінки вибирати всі посилання на інші сторінки, 
номери телефонів, поштові адреси та зберігала отриманий результат у файл.
*/

using HttpClient client = new HttpClient();
string pageContent = await client.GetStringAsync("https://brevi.com.ua/");


string linkPattern = @"https?://[^\s""<>]+";
string phonePattern = @"0\d{9}";
string emailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

var links = Regex.Matches(pageContent, linkPattern);
var phones = Regex.Matches(pageContent, phonePattern);
var emails = Regex.Matches(pageContent, emailPattern);

string path = @"C:\Users\User\OneDrive\Рабочий стол\C#\SiteInfo.txt";

using (StreamWriter writer = new StreamWriter(path))
{
    writer.WriteLine("Посилання:");
    foreach (Match link in links)
    {
        writer.WriteLine(link.Value);
    }
    writer.WriteLine("Телефони:");
    foreach (Match phone in phones)
    {
        writer.WriteLine(phone.Value);
    }
    writer.WriteLine("Пошта:");
    foreach (Match email in emails)
    {
        writer.WriteLine(email.Value);
    }
}

/*
 * Завдання 3

Напишіть жартівливу програму «Дешифратор», яка в текстовому файлі могла б замінити всі прийменники слово «ГАВ!».
*/

string pathInputFile = @"C:\Users\User\OneDrive\Рабочий стол\C#\Input.txt";
string pathOutputFile = @"C:\Users\User\OneDrive\Рабочий стол\C#\Output.txt";

if (!File.Exists(pathInputFile))
{
    Console.WriteLine("Файл не знайдено! Створіть input.txt з текстом.");
    return;
}

string text = File.ReadAllText(pathInputFile);

string pattern = @"\s\b\w{1,3}\b\s";

text = Regex.Replace(text, pattern, " ГАВ! ", RegexOptions.IgnoreCase);

using StreamWriter writer2 = new StreamWriter(pathOutputFile);
{ 
    writer2.WriteLine(text);
}

Console.WriteLine("Файл оброблено! Перевірте Output.txt.");

/*
 * Завдання 4 

Створіть текстовий файл-чек на кшталт «Найменування товару – 0.00(ціна)грн.» 
з певною кількістю найменувань товарів та датою здійснення покупки. 
Виведіть на екран інформацію з чека у форматі поточної локалі користувача та у форматі локалі en-US.
*/
Console.WriteLine();
string filePath = @"C:\Users\User\OneDrive\Рабочий стол\C#\Check.txt";

if (File.Exists(filePath))
{
    string[] lines = File.ReadAllLines(filePath);
    Console.WriteLine("Чек у форматі локалі користувача:");
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }

    Console.WriteLine("\nЧек у форматі en-US:");
    decimal exchangeRate = 40.0m; // Курс грн -> USD

    foreach (string line in lines)
    {
        string convertedLine = ConvertToUSFormat(line, exchangeRate);
        Console.WriteLine(convertedLine);
    }
}
else
{
    Console.WriteLine("Файл не знайдено!");
}

static string ConvertToUSFormat(string line, decimal exchangeRate)
{
    string pattern = @"(.+)\s[-–]\s(\d+[.,]?\d*)\sгрн\.";
    Match match = Regex.Match(line, pattern);

    if (match.Success)
    {
        string productName = match.Groups[1].Value.Trim();
        decimal price = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
        decimal priceInUSD = price / exchangeRate;
        return productName + " - " + priceInUSD.ToString("F2", CultureInfo.InvariantCulture) + " USD";
    }

    return line;
}