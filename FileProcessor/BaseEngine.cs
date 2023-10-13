namespace FileProcessor
{
    // Summary:
    // This internal abstract class, BaseEngine, serves as a base class for engines
    // that involve parsing files. It declares an abstract method GetParserForFile,
    // which is responsible for determining the appropriate file parser.
    internal abstract class BaseEngine

    {
        // Summary:
        // This abstract method must be implemented by derived classes.
        // It is responsible for returning the appropriate file parser for a given file path.

        // Parameters:
        // - filePath: The path of the file for which a parser needs to be determined.

        // Returns:
        // An instance of IFileParser representing the appropriate file parser
        public abstract IFileParser GetParserForFile(string filePath);


        // Summary:
        // This method iterates through a list of file paths and invokes the ParseFile method for each.

        // Parameters:
        // - files: A list of file paths to be parsed.
        public void ParseFiles(List<string> files)
        {
            foreach (string file in files)
            {
                ParseFile(file);
            }
        }

        // Summary:
        // This method performs the parsing of a single file using the appropriate file parser.
        // It then writes the parsed text to an output file.

        // Parameters:
        // - file: The path of the file to be parsed.

        public void ParseFile(string file)
        {
            // Obtain the appropriate file parser for the given file
            IFileParser parser = GetParserForFile(file);

            // Check if a valid parser is obtained
            if (parser != null)
            {
                // Parse the file and obtain the parsed text
                string parsedText = parser.ParseFile(file);

                // Extract file name and extension
                var fileName = Path.GetFileName(file); // SampleFile.txt
                var fileExt = Path.GetExtension(file); // .txt

                // Create the output file name (e.g., SampleFile_out.txt)
                var outputFile = $"{fileName.Replace(fileExt, "")}_out.txt"; //SampleFile_out.txt

                // Write the parsed text to an output file in the Output directory
                using var sw = new StreamWriter($"Output\\{outputFile}");
                sw.WriteLine(parsedText);
            }
        }
    }
}
