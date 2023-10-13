# FileProcessor

The FileProcessor is a program designed to process different types of files (CSV, JSON, TXT, XML) and provides a framework for extending to handle additional file types. The program reads files from an input directory, performs specific processing based on file types, and generates formatted output.

## Getting Started

Follow the steps below to build and run the FileProcessor:

### Prerequisites

- .NET SDK installed on your machine.

### Building the FileProcessor

1. **Define FileParser Interface:**
   - Create an interface named `IFileParser` that declares a method `ParseFile(string filePath)` to parse the contents of a file.

2. **Create BaseEngine Class:**
   - Implement an abstract class named `BaseEngine` that implements the `IFileParser` interface.
   - Implement the `ParseFiles(List<string> files)` method to iterate through a list of file paths and call `ParseFile` for each file.
   - Implement the `ParseFile(string file)` method to get the appropriate file parser using `GetParserForFile` and process the file content.

3. **Create EngineParser Class:**
   - Create a class named `EngineParser` that extends `BaseEngine`.
   - Implement the `GetParserForFile(string filePath)` method to return an instance of the appropriate file parser based on the file extension.

4. **Implement File Parsers:**
   - Create classes that implement the `IFileParser` interface for each file type (e.g., `CSVParser`, `JsonParser`, `TxtParser`, 'XMLParser').
   - Implement the `ParseFile` method in each class to process the specific file type and return a formatted string.

5. **Define Data Classes:**
   - Create classes to represent structured data from different file types (e.g., `Student`, `Phone`, `Address`).
   - Annotate the properties of these classes with `JsonPropertyName` attributes to map them to corresponding JSON properties during deserialization.

6. **Use EngineParser in Main Program:**
   - In your main program, instantiate an `EngineParser` object.
   - Set up the input and output directories.
   - Retrieve a list of file paths from the input directory.
   - Filter the list based on file types you want to process (e.g., TXT, CSV).
   - Call the `ParseFiles` method on the `EngineParser` object to process the files.

7. **Handle Exceptions:**
   - Implement exception handling in the `ParseFile` methods to catch and handle any errors that may occur during file processing.
   - Print relevant error messages or log the exceptions.

8. **Run the Program:**
   - Execute the main program to run the FileProcessor.
   - Verify that files in the input directory are processed correctly, and the output is generated in the specified output directory.

9. **Debug and Refine:**
   - Debug the program if necessary, especially if there are unexpected errors or issues.
   - Refine the code for better performance or to meet specific requirements.


## Usage Example

```csharp
// Sample code to demonstrate FileProcessor usage

var engineParser = new EngineParser();
var inputDirectory = $"{Directory.GetCurrentDirectory()}\\Input";
var outputDirectory = $"{Directory.GetCurrentDirectory()}\\Output";

var files = Directory.GetFiles(inputDirectory);

// Optionally filter files based on file types
var fileList = files.Where(file => file.EndsWith(".txt") || file.EndsWith(".csv")).ToList();

engineParser.ParseFiles(fileList);

