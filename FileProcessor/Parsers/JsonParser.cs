using FileProcessor.Json_Classes;
using Newtonsoft.Json;
using System.Text;

namespace FileProcessor.Parsers
{
    // Summary:
    // This internal class, JsonParser, implements the IFileParser interface and is responsible for parsing JSON files.
    // It uses JSON deserialization to convert the contents of a JSON file into an object of type Student.
    internal class JsonParser : IFileParser
    {
        // Summary:
        // Parses the contents of a JSON file and returns a formatted string representing the parsed information.

        // Parameters:
        // - filePath: The path of the JSON file to be parsed.

        // Returns:
        // A formatted string containing information parsed from the JSON file.
        public string ParseFile(string filePath)
        {
            // Use a StreamReader to read the contents of the JSON file
            using var sr = new StreamReader(filePath);

            // Deserialize the JSON contents into a Student object
            var student = JsonConvert.DeserializeObject<Student>(sr.ReadToEnd());

            // Create a StringBuilder to build the formatted output string
            var sb = new StringBuilder();

            // Append the initial line number to the StringBuilder
            sb.Append("Line#1 : ");

            // Append student information to the StringBuilder
            sb.Append($"{student.FirstName} {student.LastName} ==> ");

            // Append enrollment status and years if enrolled
            if (student.IsEnrolled)
                sb.Append($"Enrolled for {student.YearsEnrolled} years ==> ");
            else
                sb.Append("Is Not Enrolled ==> ");

            // Append Address 1 if present
            if (student.Address1 != null)
                sb.Append($"Address 1= [{student.Address1.StreetAddress}, {student.Address1.State} {student.Address1.State}, {student.Address1.PostalCode}] ==> ");


            // Append Address 2 if present
            if (student.Address2 != null)
                sb.Append($"Address 2= [{student.Address2.StreetAddress}, {student.Address2.State} {student.Address2.State}, {student.Address2.PostalCode}] ==> ");


            // Append phone numbers if present
            if (student.PhoneNumbers != null)
            {
                for (int i = 0; i < student.PhoneNumbers.Count; i++)
                {
                    var phone = student.PhoneNumbers[i];
                    sb.Append($"Phone#{i + 1}= [{phone.Type} - {phone.Number}");


                    // Append "(Do Not Contact!)" if CanContact is false
                    if (!phone.CanContact)
                        sb.Append(" (Do Not Contact!)");

                    sb.Append("] ==> ");
                }
            }

            // Trim the output string and handle trailing "==>"
            string output = sb.ToString().Trim();

            if (output.EndsWith("==>"))
                output = output.Substring(0, output.Length - 3);

            // Return the formatted string containing parsed information from the JSON file
            return output;
        }
    }
}
