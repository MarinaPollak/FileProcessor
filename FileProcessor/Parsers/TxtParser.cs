using System.Text;

namespace FileProcessor
{
    // Summary:
    // This internal class, TxtParser, implements the IFileParser interface and is responsible for parsing text (TXT) files.
    internal class TxtParser : IFileParser
    {
        // Summary:
        // Parses the contents of a text file (TXT) and returns a formatted string representing the parsed information.

        // Parameters:
        // - filePath: The path of the text file to be parsed.

        // Returns:
        // A formatted string containing information parsed from the text file.

        public string ParseFile(string filePath)
        {

            // Use a StreamReader to read the contents of the text file
            using var sr = new StreamReader(filePath);

            // Read the entire content of the text file into a string
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

                // Split the line into fields based on the pipe character '|'
                var fields = line.Split('|');

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

            // Return the formatted string containing parsed information from the text file
            return sb.ToString();
        }
    }
}
