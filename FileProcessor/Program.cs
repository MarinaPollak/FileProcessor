
using FileProcessor;



// Set up input and output directories
string inputDirectory = $"{Directory.GetCurrentDirectory()}\\Input";
string outputDirectory = $"{Directory.GetCurrentDirectory()}\\Output";

// Create directories if they don't exist
Directory.CreateDirectory(inputDirectory); // create directory if it doesn't exist.
Directory.CreateDirectory(outputDirectory); // create directory if it doesn't exist.

// Welcome message
Console.WriteLine("Welcome to the File Processor!");
Console.WriteLine($"Any files located in {inputDirectory} will be processed and sent to {outputDirectory}.\n");


// Check for files in the input directory
Console.WriteLine("Parsing files now...");
var files = Directory.GetFiles(inputDirectory);
if (files.Length == 0)
{
    Console.WriteLine("There are no files found in the input directory. Unable to parse anything. Please put some files in there.");
    return;
}

// Initialize and run the FileProcessor engine
var engine = new ParserEngine();
engine.ParseFiles(files.ToList());

// Completion message
Console.WriteLine("Done parsing files. Press any key to continue...");
Console.ReadLine();

//The program sets up input and output directories, creating them if they don't exist.
//It displays a welcome message and information about where files will be processed.
//Checks for files in the input directory; if none are found, it displays a message and exits.
//Initializes a FileProcessorEngine to parse the files.
//The FileProcessorEngine invokes the ParseFile method of the ParserEngine for each file.
//The ParserEngine is a placeholder class for file parsing logic(you can customize it according to your requirements).
//After processing files, the program displays a completion message.


