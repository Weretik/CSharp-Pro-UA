# C# Pro UA

## Overview

This repository contains solutions to C# homework assignments based on **The C# Video Course for Professionals**. The course focuses on an in-depth study of the **Microsoft .NET Framework** platform and the **C# language**. Topics covered include reflection and attributes, serialization, garbage collection, working with the file system, datasets, strings, XML, and more.

## Project Structure

1. **Custom Collections**  
   - **Task 2**: Implemented a [`MonthCollection`](./1.%20Custom%20collections/MonthCollection.cs) class that stores month names, their order numbers, and the number of days in each month. Implemented search functionality by order number or days.
   - **Task 3**: Developed a [`FamilyMember`](./1.%20Custom%20collections/FamilyMember.cs) collection resembling a **family tree**, allowing adding/removing family members and filtering by birth year.
   - **Task 4**: Created a [`DictionaryEntry`](./1.%20Custom%20collections/DictionaryEntry.cs) class for a multilingual dictionary, enabling retrieval of either the Russian or English translation for a Ukrainian word.
   - **Task 6**: Implemented a method in [`Program.cs`](./1.%20Custom%20collections/Program.cs) that takes an array of integers and returns a collection of squares of all odd numbers using the `yield` operator.

2. **System Collections**  
   - **Task 2**: Implemented in [`Program.cs`](./2.%20System%20collections/Program.cs). Created a collection where customers and the categories of purchased products are stored. The collection allows retrieving purchased categories per customer or determining customers by product category.
   - **Task 3**: Implemented in [`Program.cs`](./2.%20System%20collections/Program.cs). Created multiple collection implementations that store only integers and floating-point values, similar to a "company account – available balance" structure.
   - **Task 4**: Implemented in [`Program.cs`](./2.%20System%20collections/Program.cs). Developed an `OrderedDictionary` collection with custom comparison capabilities.
   - **Task 6**: Implemented in [`Program.cs`](./2.%20System%20collections/Program.cs). Used `SortedList` to create a collection and displayed key-value pairs in alphabetical order and then in reverse order.

### 3. **Input and Output Programming**  
   - **Task 2**: Implemented in [`Program.cs`](./3.%20Input%20and%20Output%20Programming/Program.cs). Created a file, wrote arbitrary data into it, closed the file, then reopened it, read the data, and displayed it on the console.
   - **Task 3**: Implemented in [`Program.cs`](./3.%20Input%20and%20Output%20Programming/Program.cs). Developed a program to search for a specified file on disk. Added functionality using `FileStream` to view the file in a text window and provided an option to compress the found file.
   - **Task 6**: Implemented in [`Program.cs`](./3.%20Input%20and%20Output%20Programming/Program.cs). Created 100 directories named `Folder_0` to `Folder_99` on disk and then deleted them.


### 4. Working with Text. Regular Expressions  
- **Task 2**: Implemented in [`Program.cs`](./4.%20Working%20with%20text.%20Regular%20expressions/Program.cs). Extracted all links, phone numbers, and email addresses from a given web page and saved them to a file.  
- **Task 3**: Implemented in [`Program.cs`](./4.%20Working%20with%20text.%20Regular%20expressions/Program.cs). Created a "Decoder" program that replaces all prepositions in a text file with the word "BARK!".  
- **Task 4**: Implemented in [`Program.cs`](./4.%20Working%20with%20text.%20Regular%20expressions/Program.cs). Generated a receipt file containing "Product Name – Price UAH" entries with a purchase date and displayed it in both the user's current locale and `en-US` format.  
- **Task 6**: Implemented in [`Program.cs`](./4.%20Working%20with%20text.%20Regular%20expressions/Program.cs). Developed a console program that allows users to register with a `Login` consisting only of Latin alphabet characters and a `Password` composed of numbers and symbols.  



## Requirements

- .NET SDK (latest stable version)
- C# compiler
- IDE of your choice (Visual Studio, JetBrains Rider, or VS Code with C# extension)

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Weretik/CSharp-Pro-UA.git
   ```
2. Open the project in your preferred IDE.
3. Navigate to the specific topic folder.
4. Run the `Program.cs` file within that topic to execute the examples.

## License

This project is open-source and available under the MIT License.