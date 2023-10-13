namespace FileProcessor
{
    // Summary:
    // This internal interface, IFileParser, defines the contract for classes that perform file parsing.
    // Any class implementing this interface must provide a method named ParseFile that takes a file path
    // as input and returns a string representing the parsed information from the file.
    internal interface IFileParser
    {
        // Summary:
        // Parses the contents of a file and returns a formatted string representing the parsed information.

        // Parameters:
        // - filePath: The path of the file to be parsed.

        // Returns:
        // A string containing information parsed from the file.
        string ParseFile(string filePath);
    }
}
