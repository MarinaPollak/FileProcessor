using FileProcessor.Xml_Classes;
using System.Text;
using System.Xml.Serialization;

namespace FileProcessor.Parsers
{
    // Summary:
    // This internal class, XmlParser, implements the IFileParser interface and is responsible for parsing XML files.
    // It uses XML deserialization to convert the contents of an XML file into an object of type Grocery.

    internal class XmlParser : IFileParser
    {
        // Summary:
        // Parses the contents of an XML file and returns a formatted string representing the parsed information.

        // Parameters:
        // - filePath: The path of the XML file to be parsed.

        // Returns:
        // A formatted string containing information parsed from the XML file.

        public string ParseFile(string filePath)
        {
            // Use a StreamReader to read the contents of the XML file
            using var sr = new StreamReader(filePath);

            // Create an instance of XmlSerializer for deserialization
            XmlSerializer serializer = new XmlSerializer(typeof(Grocery));

            // Deserialize the XML contents into a Grocery object
            var inventory = (Grocery)serializer.Deserialize(sr);

            // Create a StringBuilder to build the formatted output string
            var sb = new StringBuilder();


            // Iterate through each grocery item in the inventory and append information to the StringBuilder
            for (int i = 0; i < inventory.Items.Count; i++)
            {
                var item = inventory.Items[i];
                sb.AppendLine($"Line#{i + 1} : Item Info => {item.Name} {item.Price}/{item.Uom}");
            }

            // Return the formatted string containing parsed information from the XML file
            return sb.ToString();
        }
    }
}
