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