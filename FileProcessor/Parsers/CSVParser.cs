using System.Text;

namespace FileProcessor.Parsers
{
    // Summary:
    // This internal class, CSVParser, implements the IFileParser interface and is responsible for parsing CSV (Comma-Separated Values) files.
    internal class CSVParser : IFileParser
    {
        // Summary:
        // Parses the contents of a CSV file and returns a formatted string representing the parsed information.

        // Parameters:
        // - filePath: The path of the CSV file to be parsed.

        // Returns:
        // A formatted string containing information parsed from the CSV file.

        public string ParseFile(string filePath)
        {
            // Use a StreamReader to read the contents of the CSV file
            using var sr = new StreamReader(filePath);

            // Read the entire content of the CSV file into a string
            string fileText = sr.ReadToEnd();

            // Create a StringBuilder to build the formatted output string
            StringBuilder sb = new StringBuilder();

            // Split the file text into lines based on the newline character '\n'
            var lines = fileText.Split('\n');

            // Iterate through each line in the file
            for (int i = 0; i < lines.Length; i++)
            {
                // Append the line number to the StringBuilder
                sb.Append($"Line#{i + 1} :");

                // Get the current line
                var line = lines[i];

                // Split the line into fields based on the comma ','
                var fields = line.Split(',');

                // Iterate through each field in the line
                for (int j = 0; j < fields.Length; j++)
                {
                    // Append the field number and value to the StringBuilder
                    var field = fields[j];
                    sb.Append($"Field#{j + 1}={field}");

                    // Append ' ==> ' if it's not the last field in the line
                    if (j < fields.Length - 1)
                        sb.Append(" ==> ");
                }

                // Append newline characters for formatting
                sb.AppendLine();
                sb.AppendLine();
            }

            // Return the formatted string containing parsed information from the CSV file
            return sb.ToString();
        }
    }
}
