﻿
using System;
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