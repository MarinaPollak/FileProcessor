using FileProcessor.Parsers;

namespace FileProcessor
{
    // Summary:
    // This internal class, ParserEngine, inherits from the BaseEngine class and is responsible
    // for determining the appropriate file parser based on the file extension.
    internal class ParserEngine : BaseEngine
    {
        // Summary:
        // This method determines the appropriate file parser for a given file based on its extension.
        // It returns an instance of the corresponding file parser or null if no matching parser is found.

        // Parameters:
        // - filePath: The path of the file for which a parser needs to be determined.

        // Returns:
        // An instance of IFileParser representing the appropriate file parser, or null if no match is found.
        public override IFileParser GetParserForFile(string filePath)
        {
            // Check if the file has a ".txt" extension
            if (filePath.EndsWith(".txt"))
                return new TxtParser();

            // Check if the file has a ".csv" extension
            if (filePath.EndsWith(".csv"))
                return new CSVParser();

            // Check if the file has an ".xml" extension
            if (filePath.EndsWith(".xml"))
                return new XmlParser();

            // Check if the file has a ".json" extension
            if (filePath.EndsWith(".json"))
                return new JsonParser();

            // If no matching extension is found, return null
            return null;
        }
    }
}
