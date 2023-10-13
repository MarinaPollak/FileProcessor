using System.Text.Json.Serialization;

namespace FileProcessor.Json_Classes
{
    // Summary:
    // This internal class, Phone, represents a phone number and is used as part of the student information in the FileProcessor.Json_Classes namespace.
    internal class Phone
    {

        // Gets or sets the type of the phone number (e.g., home, mobile).
        [JsonPropertyName("type")]
        public string Type;


        // Gets or sets the actual phone number.
        [JsonPropertyName("number")]
        public string Number;



        // Gets or sets a flag indicating whether the contact is allowed.
        [JsonPropertyName("CanContact")]
        public bool CanContact;
    }
}
