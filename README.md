# C# Pro UA

**C# Pro UA** is a repository containing solutions to assignments from the **C# Video Course for Professionals**. This course provides an in-depth exploration of the **Microsoft .NET Framework** and the **C# language**, covering essential topics such as:

- Custom and system collections
- Input/output operations
- Regular expressions and text processing
- XML handling and configuration management
- Reflection, attributes, and serialization
- Memory management and garbage collection
- Versioning and design patterns


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


### 5. XML. Configuration Files. Registry  
- **Task 2**: Implemented in [`Program.cs`](./5.%20XML.%20Configuration%20files.%20Registry/Program.cs). Created a program that outputs all information about a specified `.xml` file.  
- **Task 3**: Implemented in [`Program.cs`](./5.%20XML.%20Configuration%20files.%20Registry/Program.cs). Extracted and displayed only phone numbers from the `TelephoneBook.xml` file.  
- **Task 4**: Implemented in [`Program.cs`](./5.%20XML.%20Configuration%20files.%20Registry/Program.cs). Developed an **administrator program** that saves configuration data in a special file or Windows registry. Created a **user program** whose interface can be controlled by the admin program.  
- **Task 6**: Implemented in [`Program.cs`](./5.%20XML.%20Configuration%20files.%20Registry/Program.cs). Generated an `.xml` file named `TelephoneBook.xml`, which follows these specifications:  
   - Root element: **`MyContacts`**  
   - Each contact is represented by a **`Contact`** tag with the contact name and an attribute **`TelephoneNumber`** containing the phone number.  


### 6. Reflection  
- **Task 2**: Implemented in [`Program.cs`](./CSharpClient/Program.cs). Created a custom **assembly** following the example of `CarLibrary` from the lesson. This assembly is used for a [`temperature converter`](./TemperatureLibrary/TemperatureConverter.cs).  
- **Task 3**: Implemented in [`Program.cs`](./LoadAssembly/Program.cs). Developed a program that provides the user access to the assembly from **Task 2**. Implemented a method for **converting temperature** from Celsius to Fahrenheit using **only reflection**.  
- **Task 5**: Implemented in [`Program.cs`](./Reflector/Program.cs). Created a **reflection-based program** that retrieves information about an assembly and the types contained in it. The base for this implementation was taken from the **lesson's reflector program**.  


### 7. Attributes  
- **Task 2**: Implemented in [`MyClass.cs`](./7.%20Attributes/MyClass.cs). Applied the **Obsolete** attribute to methods, demonstrating warnings and compilation errors.  
- **Task 3**: Implemented in [`Program.cs`](./7.%20Attributes/Program.cs). Extended the **reflection program**, adding filtering of type members and attribute display.  
- **Task 5**: Implemented in [`SecureSystem.cs`](./7.%20Attributes/SecureSystem.cs). Created a **custom attribute** for defining user access levels and implemented role-based access control.  


### 8. Serialization  
- **Task 2**: Implemented in [`Program.cs`](./8.%20Serialization/Program.cs). Created a **serializable class** and performed XML serialization with **default formatting** and modified it to store field values as **XML attributes**.  
- **Task 3**: Implemented in [`Program.cs`](./8.%20Serialization/Program.cs). Deserialized the object from **Task 2** and displayed its state.  
- **Task 5**: Implemented in [`Program.cs`](./8.%20Serialization/Program.cs). Created a **custom type**, serialized its object, considering **network transmission** requirements.  


### 9. Garbage Collector  
- **Task 2**: Implemented in [`Program.cs`](./9.%20Garbage%20collector/Program.cs). Created a **resource monitoring class** that tracks memory usage and issues warnings when consumption approaches a set threshold.  
- **Task 4**: Implemented in [`Program.cs`](./9.%20Garbage%20collector/Program.cs). Developed a **memory-intensive class** with a large array and implemented a **formalized cleanup pattern**.  


### 10. Versioning  
- **Task 2**: Implemented in [`Program.cs`](./10.%20Versioning/Program.cs). Studied the **Template Method pattern** and implemented its abstract version in C#.  
- **Task 4**: Implemented in [`Program.cs`](./10.%20Versioning/Program.cs). Applied the **Non-Virtual Interface (NVI) pattern** in a custom inheritance hierarchy.  


### 11. Threads  
- **Task 2**: Implemented in [`Program.cs`](./11.%20Threads/Program.cs). Created a **console application** that reads from two files in parallel threads and writes the data into a third file using **thread synchronization**.  
- **Task 4**: Implemented in [`Program.cs`](./11.%20Threads/Program.cs). Modified thread execution to ensure the **sequential operation of three threads** using **locking mechanisms**.  


### 12. Synchronization  
- **Task 3**: Implemented in [`Program.cs`](./12.%20Synchronization/Program.cs). Created a program that allows **only one instance** to run at a time using a **named Mutex**.  
- **Task 5**: Implemented in [`Program.cs`](./12.%20Synchronization/Program.cs). Used a **Semaphore** to control access to a resource from multiple threads, ensuring an **ordered log output**.  


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
